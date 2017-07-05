using System;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Extensions;
using TroyTrivia.Business.Infrastructure;
using TroyTrivia.Business.Interactors;

namespace TroyTrivia.Business.Entities
{
    public class QuestionHistory
    {
        [ExplicitKey]
        public Guid QuestionId { get; set; }
        public Location Location { get; set; }
        public DateTime DateUsed { get; set; }

        public void Insert()
        {
            var sqlInteractor = new SqliteInteractor();

            sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.ExecuteNonQuery(
                    "INSERT INTO [QuestionHistory] (QuestionId, [DateUsed], [_LocationId]) VALUES (@QuestionId, @DateUsed, @LocationId)",
                    new {QuestionId = this.QuestionId, DateUsed = this.DateUsed, LocationId = this.Location.Id})
            );
        }
    }
}
