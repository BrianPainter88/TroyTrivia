using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Infrastructure;
using TroyTrivia.Business.Interactors;

namespace TroyTrivia.Business.Entities
{
    [Table("QuestionTypes")]
    public class QuestionType
    {
        [ExplicitKey]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public QuestionType()
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

        public static IEnumerable<QuestionType> Select()
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.GetAll<QuestionType>()
            );
        }

        public static QuestionType Select(Guid typeId)
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Get<QuestionType>(typeId)
            );
        }

        public static QuestionType Select(string typeName)
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.GetAll<QuestionType>().FirstOrDefault(t => t.Name.Equals(typeName, StringComparison.InvariantCultureIgnoreCase))
            );
        }
    }
}
