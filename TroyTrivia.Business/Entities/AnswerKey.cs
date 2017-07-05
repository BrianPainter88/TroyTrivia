using System;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Infrastructure;
using TroyTrivia.Business.Interactors;

namespace TroyTrivia.Business.Entities
{
    public class AnswerKey
    {
        [ExplicitKey]
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public Guid QuestionId { get; set; }

        public AnswerKey()
        {
            Order = 1;
            Id = Guid.NewGuid();
        }

        public AnswerKey(Guid questionId) : this()
        {
            QuestionId = questionId;
        }

        public void Insert()
        {
            var sqlInteractor = new SqliteInteractor();
            sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Insert(this)
            );
        }

        public void Update()
        {
            var sqlInteractor = new SqliteInteractor();
            sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Update(this)
            );
        }

        public bool Delete()
        {
            var sqlInteractor = new SqliteInteractor();
            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Delete(this)
            );
        }
    }
}
