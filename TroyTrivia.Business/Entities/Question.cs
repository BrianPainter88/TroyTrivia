using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TroyTrivia.Business.Extensions;

namespace TroyTrivia.Business.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public QuestionType Type { get; set; }
        public QuestionDifficulty Difficulty { get; set; }
        public Category Category { get; set; }
        public string QuestionText { get; set; }
        public IEnumerable<AnswerKey> Answer { get; set; }
        public IEnumerable<QuestionHistory> LastUsed { get; set; }

        public string GetAnswer()
        {
            IList<string> answers = new List<string>();

            foreach (var answer in Answer.OrderByDescending(k => k.Order))
            {
                answers.Add($"{answer.Order}. {answer.Text} ({answer.Description})");
            }

            return string.Join(Environment.NewLine, answers);
        }

        public int Insert(IDbConnection connection)
        {
            var questionId = connection.ExecuteScalarQuery<int>(
                @"INSERT INTO Questions (QuestionText, _QuestionTypeId, _QuestionDifficultyId, _CategoryId) VALUES (@QuestionText, @QuestionTypeId, @QuestionDifficultyId, @CategoryId); 
			SELECT last_insert_rowid();",
                new { QuestionText = this.QuestionText, QuestionTypeId = (int)this.Type, QuestionDifficultyId = this.Difficulty, CategoryId = this.Category.Id }
            );

            foreach (var answerKey in this.Answer)
            {
                answerKey.Insert(connection, questionId);
            }

            return questionId;
        }

        public void Update(IDbConnection connection)
        {
            connection.ExecuteNonQuery(
                @"UPDATE [Questions] SET [QuestionText] = @QuestionText, [_QuestionTypeId] = @QuestionType, [_QuestionDifficultyId] = @Difficulty, [_CategoryId] = @CategoryId WHERE [QuestionId] = @QuestionId",
                new { QuestionText = this.QuestionText, QuestionType = this.Type, Difficulty = this.Difficulty, CategoryId = this.Category, QuestionId = this.Id }
            );

            foreach (var answerKey in Answer)
            {
                answerKey.Update(connection);
            }
        }

        public IEnumerable<Question> Select(IDbConnection connection)
        {
            IEnumerable<Question> baseObjects = connection.Query<Question>(@"SELECT [Id], [QuestionText] FROM [Questions]");

            foreach (var baseObject in baseObjects)
            {
                baseObject.Answer = connection.Query<AnswerKey>(@"SELECT [Id], [Text], [Description], [Order] FROM [AnswerKeys] WHERE [_QuestionId] = @QuestionId",
                    new { QuestionId = baseObject.Id }).OrderByDescending(ak => ak.Order);

                var questionType = connection.QuerySingle<int>(@"SELECT [_QuestionTypeId] FROM [Questions] WHERE [Id] = @Id", new { Id = baseObject.Id });
                baseObject.Type = (QuestionType)questionType;

                baseObject.Category = connection.QuerySingle<Category>
                (
                    @"SELECT [Categories].[Id], [Categories].[Name] FROM [Questions] LEFT OUTER JOIN [Categories] ON [Categories].[Id] = [Questions].[_CategoryId] WHERE [Questions].[Id] = @Id",
                    new { Id = baseObject.Id }
                );
            }

            return baseObjects;
        }

        public Question Select(IDbConnection connection, int questionId)
        {
            Question baseObject = connection.QuerySingle<Question>(@"SELECT [Id], [QuestionText] FROM [Questions] WHERE [Id] = @Id", new { Id = questionId });

            baseObject.Answer = connection.Query<AnswerKey>(@"SELECT [Id], [Text], [Description], [Order] FROM [AnswerKeys] WHERE [_QuestionId] = @QuestionId",
                new { QuestionId = questionId }).OrderByDescending(ak => ak.Order);

            var questionType = connection.QuerySingle<int>(@"SELECT [_QuestionTypeId] FROM [Questions] WHERE [Id] = @Id", new { Id = questionId });
            baseObject.Type = (QuestionType)questionType;

            baseObject.Category = connection.QuerySingle<Category>(
                @"SELECT [Categories].[Id], [Categories].[Name] FROM [Questions] LEFT OUTER JOIN [Categories] ON [Categories].[Id] = [Questions].[_CategoryId] WHERE [Questions].[Id] = @Id",
                new { Id = questionId }
            );

            return baseObject;
        }

        #region Enums

        public enum QuestionType
        {
            TrueFalse = 1,
            Ordered,
            Standard
        };

        public enum QuestionDifficulty
        {
            Easy = 1,
            Medium = 2,
            Hard = 3
        };

        #endregion
    }
}
