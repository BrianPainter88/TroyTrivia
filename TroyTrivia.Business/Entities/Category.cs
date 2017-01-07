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
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Insert(IDbConnection connection)
        {
            connection.ExecuteNonQuery(@"INSERT INTO [Categories] ([Name]) VALUES (@CategoryName)", new { CategoryName = this.Name });
        }

        public void Update(IDbConnection connection)
        {
            connection.ExecuteNonQuery(@"UPDATE [Categores] SET [Name] = @Name WHERE [Id] = @Id", new { Name = this.Name, Id = this.Id });
        }

        public IEnumerable<Category> Select(IDbConnection connection)
        {
            return connection.Query<Category>(@"SELECT [Id], [Name] FROM [Categories]");
        }

        public IEnumerable<Category> Select(IDbConnection connection, int categoryId)
        {
            return connection.Query<Category>(@"SELECT [Id], [Name] FROM [Categories] WHERE [CategoryId] = @CategoryId", new { CategoryId = categoryId });
        }
    }
}
