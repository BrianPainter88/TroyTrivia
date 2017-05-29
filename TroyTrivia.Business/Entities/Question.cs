using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Extensions;

namespace TroyTrivia.Business.Entities
{
    public class Question
    {
        [ExplicitKey]
        public Guid Id { get; set; }
        public QuestionType Type { get; set; }
        public QuestionDifficulty Difficulty { get; set; }
        public Category Category { get; set; }
        public string QuestionText { get; set; }
        public IEnumerable<AnswerKey> Answer { get; set; }
        public IEnumerable<QuestionHistory> LastUsed { get; set; }
        public Question BonusQuestion { get; set; }
        public int BonusPoints { get; set; }
        public string AnswerText => GetAnswer();

        public Question()
        {
            Id = Guid.NewGuid();
        }

        public string GetAnswer()
        {
            IList<string> answers = new List<string>();

            foreach (var answer in Answer.OrderByDescending(k => k.Order))
            {
                answers.Add($"{answer.Order}. {answer.Text} ({answer.Description})");
            }

            return string.Join(Environment.NewLine, answers);
        }

        public static Question GetRandomQuestionByDifficulty(IDbConnection connection, Guid difficulty)
        {
            var commandParameters = new { difficultyId = difficulty };
            var commandDefinition = new CommandDefinition(
                "SELECT Id FROM [Questions] WHERE [QuestionDifficultyId] = @difficultyId ORDER BY RANDOM() LIMIT 1",
                commandParameters
            );

            var questionId = connection.ExecuteScalar<Guid>(commandDefinition);

            return
                Select(connection, questionId);
        }

        public static Question GetRandomQuestionByType(IDbConnection connection, Guid type)
        {
            var commandParameters = new
            {
                typeId = type
            };

            var commandDefinition = new CommandDefinition(
                "SELECT Id FROM [Questions] WHERE [QuestionTypeId] = @typeId ORDER BY RANDOM() LIMIT 1",
                commandParameters
            );

            var questionId = connection.ExecuteScalar<Guid>(commandDefinition);

            return
                Select(connection, questionId);
        }

        public static Question GetRandomQuestion(IDbConnection connection, Guid difficultyId, Guid typeId)
        {
            var commandParameters = new
            {
                difficultyId = difficultyId,
                typeId = typeId
            };

            var commandDefinition = new CommandDefinition(
                "SELECT Id FROM [Questions] WHERE [QuestionDifficultyId] = @difficultyId AND [QuestionTypeId] = @typeId ORDER BY RANDOM() LIMIT 1",
                commandParameters
            );

            var questionId = connection.ExecuteScalar<Guid>(commandDefinition);

            return
                Select(connection, questionId);
        }

        public Guid Insert(IDbConnection connection)
        {
            var questionId = this.Id;
            connection.ExecuteScalarQuery<Guid>(
                @"INSERT INTO Questions (Id, QuestionText, QuestionTypeId, QuestionDifficultyId, CategoryId) VALUES (@Id, @QuestionText, @QuestionTypeId, @QuestionDifficultyId, @CategoryId);",
                new
                {
                    Id = questionId,
                    QuestionText = this.QuestionText,
                    QuestionTypeId = this.Type.Id,
                    QuestionDifficultyId = this.Difficulty.Id,
                    CategoryId = this.Category.Id
                }
            );

            foreach (var answerKey in this.Answer)
            {
                answerKey.QuestionId = questionId;
                answerKey.Insert(connection);
            }

            return questionId;
        }

        public void Update(IDbConnection connection)
        {
            connection.ExecuteNonQuery(
                @"UPDATE [Questions] SET [QuestionText] = @QuestionText, [QuestionTypeId] = @QuestionType, [QuestionDifficultyId] = @Difficulty, [CategoryId] = @CategoryId WHERE [QuestionId] = @QuestionId",
                new
                {
                    QuestionText = this.QuestionText,
                    QuestionType = this.Type.Id,
                    Difficulty = this.Type.Id,
                    CategoryId = this.Category,
                    QuestionId = this.Id
                }
            );

            foreach (var answerKey in Answer)
            {
                answerKey.Update(connection);
            }
        }

        public static IEnumerable<Question> Select(IDbConnection connection)
        {
            IEnumerable<Question> baseObjects = connection.Query<Question>(@"SELECT [Id], [QuestionText] FROM [Questions]");

            foreach (var baseObject in baseObjects)
            {
                baseObject.Answer = connection.Query<AnswerKey>(@"SELECT [Id], [Text], [Description], [Order], [QuestionId] FROM [AnswerKeys] WHERE [QuestionId] = @QuestionId",
                    new { QuestionId = baseObject.Id }).OrderByDescending(ak => ak.Order);

                var questionType = connection.QuerySingle<Guid>(@"SELECT [QuestionTypeId] FROM [Questions] WHERE [Id] = @Id", new { Id = baseObject.Id });
                baseObject.Type = QuestionType.Select(connection, questionType);

                var questionDifficulty = connection.QuerySingle<Guid>(@"SELECT [QuestionDifficultyId] FROM [Questions] WHERE [Id] = @Id", new { Id = baseObject.Id });
                baseObject.Difficulty = QuestionDifficulty.Select(connection, questionDifficulty);

                baseObject.Category = connection.QuerySingle<Category>
                (
                    @"SELECT [Categories].[Id], [Categories].[Name] FROM [Questions] LEFT OUTER JOIN [Categories] ON [Categories].[Id] = [Questions].[CategoryId] WHERE [Questions].[Id] = @Id",
                    new { Id = baseObject.Id }
                );
            }

            return baseObjects;
        }

        public static Question Select(IDbConnection connection, Guid questionId)
        {
            Question baseObject = connection.QuerySingle<Question>(@"SELECT [Id], [QuestionText] FROM [Questions] WHERE [Id] = @Id", new { Id = questionId });

            baseObject.Answer = connection.Query<AnswerKey>(@"SELECT [Id], [Text], [Description], [Order], [QuestionId] FROM [AnswerKeys] WHERE [QuestionId] = @QuestionId",
                new { QuestionId = questionId }).OrderByDescending(ak => ak.Order);

            var questionType = connection.QuerySingle<Guid>(@"SELECT [QuestionTypeId] FROM [Questions] WHERE [Id] = @Id", new { Id = questionId });
            baseObject.Type = QuestionType.Select(connection, questionType);

            var questionDifficulty = connection.QuerySingle<Guid>(@"SELECT [QuestionDifficultyId] FROM [Questions] WHERE [Id] = @Id", new { Id = questionId });
            baseObject.Difficulty = QuestionDifficulty.Select(connection, questionDifficulty);

            baseObject.Category = connection.QuerySingle<Category>(
                @"SELECT [Categories].[Id], [Categories].[Name] FROM [Questions] LEFT OUTER JOIN [Categories] ON [Categories].[Id] = [Questions].[CategoryId] WHERE [Questions].[Id] = @Id",
                new { Id = questionId }
            );

            return baseObject;
        }

    }
}
