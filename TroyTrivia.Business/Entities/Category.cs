using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper.Contrib.Extensions;

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

        public void Insert(IDbConnection connection)
        {
            connection.Insert(this);
        }

        public void Update(IDbConnection connection)
        {
            connection.Update(this);
        }

        public static IEnumerable<Category> Select(IDbConnection connection)
        {
            return connection.GetAll<Category>();
        }

        public static Category Select(IDbConnection connection, Guid categoryId)
        {
            return connection.Get<Category>(categoryId);
        }

        public static Category Select(IDbConnection connection, string categoryName)
        {
            return connection.GetAll<Category>().FirstOrDefault(category => category.Name.Equals(categoryName, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
