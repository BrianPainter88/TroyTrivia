using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Extensions;

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

        public Guid Insert(IDbConnection connection)
        {
            var locationId = connection.ExecuteScalarQuery<Guid>(
                @"INSERT INTO [Locations] ([Id], [Name], [Phone]) VALUES (@Id, @Name, @Phone)",
                new {Id = Id, Name = this.Name, Phone = this.Phone }
            );

            Address.Insert(connection, Id);

            return locationId;
        }

        public void Update(IDbConnection connection)
        {
            connection.ExecuteNonQuery(
                @"UPDATE [Locations] SET [Name] = @Name, [Phone] = @Phone WHERE [Id] = @LocationId",
                new { Name = this.Name, Phone = this.Phone, LocationId = this.Id }
            );

            Address.Update(connection);
        }

        public static IEnumerable<Location> Select(IDbConnection connection)
        {
            var baseLocations = connection.Query<Location>(@"SELECT [Id], [Name], [Phone] FROM [Locations]");

            foreach (var baseLocation in baseLocations)
            {
                /*
                baseLocation.Address = connection.QuerySingle<Address>(
                    @"SELECT [Id], [Address1], [Address2], [City], [State], [ZipCode], [SpecialDirections], [LocationId] FROM Addresses WHERE LocationId = @LocationId", 
                    new { LocationId = baseLocation.Id});
                */
                baseLocation.Address = baseLocation.Address.Select(connection, baseLocation.Id);
            }

            return baseLocations;
        }

        public static Location Select(IDbConnection connection, int locationId)
        {
            var location = connection.QuerySingle<Location>(
                @"SELECT [Id], [Name], [Phone] FROM [Locations] WHERE [Id] = @LocationId",
                new { LocationId = locationId }
            );

            location.Address = location.Address.Select(connection, location.Id);

            return location;
        }

        public static Location Select(IDbConnection connection, string locationName)
        {
            return connection.GetAll<Location>().FirstOrDefault(l => l.Name.Equals(locationName, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
