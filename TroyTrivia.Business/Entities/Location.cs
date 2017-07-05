using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Extensions;
using TroyTrivia.Business.Infrastructure;
using TroyTrivia.Business.Interactors;

namespace TroyTrivia.Business.Entities
{
    public class Location
    {
        [ExplicitKey]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }

        public Location()
        {
            Id = Guid.NewGuid();
            Address = new Address();
        }

        public Guid Insert()
        {
            var sqlInteractor = new SqliteInteractor();

            var locationId = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.ExecuteScalarQuery<Guid>(
                    @"INSERT INTO [Locations] ([Id], [Name], [Phone]) VALUES (@Id, @Name, @Phone)",
                    new {Id = Id, Name = this.Name, Phone = this.Phone}
                )
            );

            Address.Insert(Id);

            return locationId;
        }

        public void Update()
        {
            var sqlInteractor = new SqliteInteractor();

            sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.ExecuteNonQuery(
                    @"UPDATE [Locations] SET [Name] = @Name, [Phone] = @Phone WHERE [Id] = @LocationId",
                    new {Name = this.Name, Phone = this.Phone, LocationId = this.Id}
                )
            );

            Address.Update();
        }

        public static IEnumerable<Location> Select()
        {
            var sqlInteractor = new SqliteInteractor();

            var baseLocations = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Query<Location>(@"SELECT [Id], [Name], [Phone] FROM [Locations]")
            );

            foreach (var baseLocation in baseLocations)
            {
                baseLocation.Address = baseLocation.Address.Select(baseLocation.Id);
            }

            return baseLocations;
        }

        public static Location Select(int locationId)
        {
            var sqlInteractor = new SqliteInteractor();

            var location = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.QuerySingle<Location>(
                    @"SELECT [Id], [Name], [Phone] FROM [Locations] WHERE [Id] = @LocationId",
                    new {LocationId = locationId}
                )
            );

            location.Address = location.Address.Select(location.Id);

            return location;
        }

        public static Location Select(string locationName)
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.GetAll<Location>().FirstOrDefault(l => l.Name.Equals(locationName, StringComparison.InvariantCultureIgnoreCase))
            );
        }
    }
}
