using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Infrastructure;
using TroyTrivia.Business.Interactors;

namespace TroyTrivia.Business.Entities
{
    [Table("Categories")]
    public class Category
    {
        [ExplicitKey]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Category()
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

        public static IEnumerable<Category> Select()
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.GetAll<Category>()
            );
        }

        public static Category Select(Guid categoryId)
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Get<Category>(categoryId)
            );
        }

        public static Category Select(string categoryName)
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.GetAll<Category>()
                    .FirstOrDefault(category => category.Name.Equals(categoryName, StringComparison.InvariantCultureIgnoreCase))
            );
        }
    }
}
