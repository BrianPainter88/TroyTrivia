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
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }

        public int Insert(IDbConnection connection)
        {
            var locationId = connection.ExecuteNonQuery(
                @"INSERT INTO [Locations] ([Name], [Phone]) VALUES (@Name, @Phone)",
                new { Name = this.Name, Phone = this.Phone }
            );

            Address.Insert(connection, locationId);

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

        public IEnumerable<Location> Select(IDbConnection connection)
        {
            var baseLocations = connection.Query<Location>(@"SELECT [Id], [Name], [Phone] FROM [Locations]");

            foreach (var baseLocation in baseLocations)
            {
                baseLocation.Address = baseLocation.Address.Select(connection, this.Id);
            }

            return baseLocations;
        }

        public Location Select(IDbConnection connection, int locationId)
        {
            var location = connection.QuerySingle<Location>(
                @"SELECT [Id], [Name], [Phone] FROM [Locations] WHERE [Id] = @LocationId",
                new { LocationId = locationId }
            );

            location.Address = location.Address.Select(connection, location.Id);

            return location;
        }
    }
}
