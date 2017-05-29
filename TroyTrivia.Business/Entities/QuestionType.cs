using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper.Contrib.Extensions;

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

        public void Insert(IDbConnection connection)
        {
            connection.Insert(this);
        }

        public void Update(IDbConnection connection)
        {
            connection.Update(this);
        }

        public static IEnumerable<QuestionType> Select(IDbConnection connection)
        {
            return connection.GetAll<QuestionType>();
        }

        public static QuestionType Select(IDbConnection connection, Guid typeId)
        {
            return connection.Get<QuestionType>(typeId);
        }

        public static QuestionType Select(IDbConnection connection, string typeName)
        {
            return connection.GetAll<QuestionType>().FirstOrDefault(t => t.Name.Equals(typeName, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
