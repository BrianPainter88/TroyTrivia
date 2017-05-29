using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper.Contrib.Extensions;

namespace TroyTrivia.Business.Entities
{
    public class Team
    {
        [ExplicitKey]
        public Guid Id { get; }
        public string Name { get; set; }

        public Team()
        {
            Id = Guid.NewGuid();
        }

        public void Insert(IDbConnection connection)
        {
            if (GetCountOfTeamsWithName(connection) == 0)
            {
                connection.Insert(new Team() { Name = this.Name });
            }
            //connection.ExecuteNonQuery(@"INSERT INTO [Teams] ([Name]) VALUES (@Name)", new { Name = this.Name });
        }

        public void Update(IDbConnection connection)
        {
            if (GetCountOfTeamsWithName(connection) == 0)
            {
                connection.Update(this);
            }
            //connection.ExecuteNonQuery(@"UPDATE [Teams] SET [Name] = @Name WHERE [Id] = @Id", new { Name = this.Name, Id = this.Id });
        }

        private int GetCountOfTeamsWithName(IDbConnection connection)
        {
            return connection.GetAll<Team>().Count(team => team.Name == this.Name);
        }

        public static IEnumerable<Team> Select(IDbConnection connection)
        {
            return connection.GetAll<Team>();
        }

        public static Team Select(IDbConnection connection, Guid teamId)
        {
            return connection.Get<Team>(teamId);
        }

        public void Delete(IDbConnection connection)
        {
            connection.Delete(this);
        }
    }
}
