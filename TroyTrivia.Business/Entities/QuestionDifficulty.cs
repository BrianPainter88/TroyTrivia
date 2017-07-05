using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Infrastructure;
using TroyTrivia.Business.Interactors;

namespace TroyTrivia.Business.Entities
{
    [Table("QuestionDifficulty")]
    public class QuestionDifficulty
    {
        [ExplicitKey]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public QuestionDifficulty()
        {
            Id = Guid.NewGuid();
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

        public static IEnumerable<QuestionDifficulty> Select()
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.GetAll<QuestionDifficulty>()
            );
        }

        public static QuestionDifficulty Select(Guid difficultyId)
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Get<QuestionDifficulty>(difficultyId)
            );
        }

        public static QuestionDifficulty Select(string difficultyName)
        {
            var sqlInteractor = new SqliteInteractor();

            return
                sqlInteractor.PerformDatabaseOperation((connection) =>
                    connection.GetAll<QuestionDifficulty>()
                        .FirstOrDefault(d => d.Name.Equals(difficultyName, StringComparison.InvariantCultureIgnoreCase))
                );
        }
    }
}
