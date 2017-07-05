using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Infrastructure;
using TroyTrivia.Business.Interactors;

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

        public void Insert()
        {
            var sqlInteractor = new SqliteInteractor();

            if (GetCountOfTeamsWithName() == 0)
            {
                sqlInteractor.PerformDatabaseOperation((connection) =>
                    connection.Insert(new Team() {Name = this.Name})
                );
            }
        }

        public void Update()
        {
            var sqlInteractor = new SqliteInteractor();

            if (GetCountOfTeamsWithName() == 0)
            {
                sqlInteractor.PerformDatabaseOperation((connection) =>
                    connection.Update(this)
                );
            }
        }

        private int GetCountOfTeamsWithName()
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.GetAll<Team>().Count(team => team.Name == this.Name)
            );
        }

        public static IEnumerable<Team> Select()
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.GetAll<Team>()
            );
        }

        public static Team Select(Guid teamId)
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Get<Team>(teamId)
            );
        }

        public void Delete()
        {
            var sqlInteractor = new SqliteInteractor();

            sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Delete(this)
            );
        }
    }
}
