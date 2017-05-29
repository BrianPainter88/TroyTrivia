using System;
using System.Data;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Extensions;

namespace TroyTrivia.Business.Entities
{
    public class QuestionHistory
    {
        [ExplicitKey]
        public Guid QuestionId { get; set; }
        public Location Location { get; set; }
        public DateTime DateUsed { get; set; }

        public void Insert(IDbConnection connection)
        {
            connection.ExecuteNonQuery(
                "INSERT INTO [QuestionHistory] (QuestionId, [DateUsed], [_LocationId]) VALUES (@QuestionId, @DateUsed, @LocationId)",
                new {QuestionId = this.QuestionId, DateUsed = this.DateUsed, LocationId = this.Location.Id });
        }
    }
}
