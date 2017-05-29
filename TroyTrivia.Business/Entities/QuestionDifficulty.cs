using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper.Contrib.Extensions;

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

        public void Insert(IDbConnection connection)
        {
            connection.Insert(this);
        }

        public void Update(IDbConnection connection)
        {
            connection.Update(this);
        }

        public static IEnumerable<QuestionDifficulty> Select(IDbConnection connection)
        {
            return connection.GetAll<QuestionDifficulty>();
        }

        public static QuestionDifficulty Select(IDbConnection connection, Guid difficultyId)
        {
            return connection.Get<QuestionDifficulty>(difficultyId);
        }

        public static QuestionDifficulty Select(IDbConnection connection, string difficultyName)
        {
            return
                connection.GetAll<QuestionDifficulty>()
                    .FirstOrDefault(d => d.Name.Equals(difficultyName, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
