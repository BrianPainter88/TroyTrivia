using System;
using System.Data;
using TroyTrivia.Business.Extensions;

namespace TroyTrivia.Business.Entities
{
    public class QuestionHistory
    {
        public Location Location { get; set; }
        public DateTime DateUsed { get; set; }

        public void Insert(IDbConnection connection)
        {
            connection.ExecuteNonQuery(
                "INSERT INTO [QuestionHistory] ([DateUsed], [_LocationId]) VALUES (@DateUsed, @LocationId)",
                new { DateUsed = this.DateUsed, LocationId = this.Location.Id });
        }
    }
}
