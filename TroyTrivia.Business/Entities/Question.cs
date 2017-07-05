using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Dapper;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Extensions;
using TroyTrivia.Business.Infrastructure;
using TroyTrivia.Business.Interactors;

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

        public static Question GetRandomQuestionByDifficulty(Guid difficulty)
        {
            var sqlInteractor = new SqliteInteractor();

            var commandParameters = new { difficultyId = difficulty };
            var commandDefinition = new CommandDefinition(
                "SELECT Id FROM [Questions] WHERE [QuestionDifficultyId] = @difficultyId ORDER BY RANDOM() LIMIT 1",
                commandParameters
            );

            var questionId = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.ExecuteScalar<Guid>(commandDefinition)
            );

            return
                Select(questionId);
        }

        public static Question GetRandomQuestionByType(Guid type)
        {
            var sqliteInteractor = new SqliteInteractor();

            var commandParameters = new
            {
                typeId = type
            };

            var commandDefinition = new CommandDefinition(
                "SELECT Id FROM [Questions] WHERE [QuestionTypeId] = @typeId ORDER BY RANDOM() LIMIT 1",
                commandParameters
            );

            var questionId = sqliteInteractor.PerformDatabaseOperation((connection) =>
                connection.ExecuteScalar<Guid>(commandDefinition)
            );

            return
                Select(questionId);
        }

        public static Question GetRandomQuestion(Guid difficultyId, Guid typeId)
        {
            var sqlInteractor = new SqliteInteractor();

            var commandParameters = new
            {
                difficultyId = difficultyId,
                typeId = typeId
            };

            var commandDefinition = new CommandDefinition(
                "SELECT Id FROM [Questions] WHERE [QuestionDifficultyId] = @difficultyId AND [QuestionTypeId] = @typeId ORDER BY RANDOM() LIMIT 1",
                commandParameters
            );

            var questionId = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.ExecuteScalar<Guid>(commandDefinition)
            );

            return
                Select(questionId);
        }

        public Guid Insert()
        {
            var sqlInteractor = new SqliteInteractor();

            var questionId = this.Id;
            sqlInteractor.PerformDatabaseOperation((connection) =>
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
                )
            );

            foreach (var answerKey in this.Answer)
            {
                answerKey.QuestionId = questionId;
                answerKey.Insert();
            }

            return questionId;
        }

        public void Update()
        {
            var sqlInteractor = new SqliteInteractor();

            sqlInteractor.PerformDatabaseOperation((connection) =>
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
                ));

            foreach (var answerKey in Answer)
            {
                answerKey.Update();
            }
        }

        public static IEnumerable<Question> Select()
        {
            var sqlInteractor = new SqliteInteractor();

            IEnumerable<Question> baseObjects = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Query<Question>(@"SELECT [Id], [QuestionText] FROM [Questions]")
            );

            foreach (var baseObject in baseObjects)
            {
                baseObject.Answer = sqlInteractor.PerformDatabaseOperation((connection) =>
                    connection.Query<AnswerKey>(
                        @"SELECT [Id], [Text], [Description], [Order], [QuestionId] FROM [AnswerKeys] WHERE [QuestionId] = @QuestionId",
                        new {QuestionId = baseObject.Id}).OrderByDescending(ak => ak.Order)
                );

                var questionType = sqlInteractor.PerformDatabaseOperation((connection) =>
                    connection.QuerySingle<Guid>(@"SELECT [QuestionTypeId] FROM [Questions] WHERE [Id] = @Id", new {Id = baseObject.Id})
                );

                baseObject.Type = QuestionType.Select(questionType);

                var questionDifficulty = sqlInteractor.PerformDatabaseOperation((connection) =>
                    connection.QuerySingle<Guid>(@"SELECT [QuestionDifficultyId] FROM [Questions] WHERE [Id] = @Id", new {Id = baseObject.Id})
                );

                baseObject.Difficulty = QuestionDifficulty.Select(questionDifficulty);

                baseObject.Category = sqlInteractor.PerformDatabaseOperation((connection) =>
                    connection.QuerySingle<Category>
                    (
                        @"SELECT [Categories].[Id], [Categories].[Name] FROM [Questions] LEFT OUTER JOIN [Categories] ON [Categories].[Id] = [Questions].[CategoryId] WHERE [Questions].[Id] = @Id",
                        new {Id = baseObject.Id}
                    )
                );
            }

            return baseObjects;
        }

        public static Question Select(Guid questionId)
        {
            var sqlInteractor = new SqliteInteractor();

            Question baseObject = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.QuerySingle<Question>(@"SELECT [Id], [QuestionText] FROM [Questions] WHERE [Id] = @Id", new {Id = questionId})
            );

            baseObject.Answer = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Query<AnswerKey>(
                    @"SELECT [Id], [Text], [Description], [Order], [QuestionId] FROM [AnswerKeys] WHERE [QuestionId] = @QuestionId",
                    new {QuestionId = questionId}).OrderByDescending(ak => ak.Order)
            );

            var questionType = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.QuerySingle<Guid>(@"SELECT [QuestionTypeId] FROM [Questions] WHERE [Id] = @Id", new {Id = questionId})
            );

            baseObject.Type = QuestionType.Select(questionType);

            var questionDifficulty = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.QuerySingle<Guid>(@"SELECT [QuestionDifficultyId] FROM [Questions] WHERE [Id] = @Id", new {Id = questionId})
            );

            baseObject.Difficulty = QuestionDifficulty.Select(questionDifficulty);

            baseObject.Category = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.QuerySingle<Category>(
                    @"SELECT [Categories].[Id], [Categories].[Name] FROM [Questions] LEFT OUTER JOIN [Categories] ON [Categories].[Id] = [Questions].[CategoryId] WHERE [Questions].[Id] = @Id",
                    new {Id = questionId}
                )
            );

            return baseObject;
        }

        public bool Delete()
        {
            foreach (var answerKey in this.Answer)
            {
                answerKey.Delete();
            }

            var sqlInteractor = new SqliteInteractor();
            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Delete(this)
            );
        }
    }
}
