using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Extensions;

namespace TroyTrivia.Business.Entities
{
    public class Address
    {
        [ExplicitKey]
        public Guid Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string SpecialDirections { get; set; }

        public Address()
        {
            Id = Guid.NewGuid();
        }

        public Guid Insert(IDbConnection connection, Guid locationId)
        {
            var addressId = connection.ExecuteScalarQuery<Guid>(
                @"INSERT INTO [Addresses] ([Id], [Address1], [Address2], [City], [State], [ZipCode], [SpecialDirections], [LocationId])
			VALUES (@Id, @Address1, @Address2, @City, @State, @ZipCode, @SpecialDirections, @LocationId)",
                new { Id = Id, Address1 = this.Address1, Address2 = this.Address2, City = this.City, State = this.State, ZipCode = this.ZipCode, SpecialDirections = this.SpecialDirections, locationId }
            );

            return addressId;
        }

        public void Update(IDbConnection connection)
        {
            connection.ExecuteNonQuery(
                @"UPDATE [Addresses] SET [Address1] = @Address1, [Address2] = @Address2, [City] = @City, [State] = @State, [ZipCode] = @ZipCode, [SpecialDirections] = @SpecialDirections 
			WHERE [Id] = @AddressId",
                new { Address1 = this.Address1, Address2 = this.Address2, City = this.City, State = this.State, ZipCode = this.ZipCode, SpecialDirections = this.SpecialDirections, AddressId = this.Id }
            );
        }

        public static IEnumerable<Address> Select(IDbConnection connection)
        {
            return connection.Query<Address>(@"SELECT [Id], [Address1], [Address2], [City], [State], [ZipCode], [SpecialDirections] FROM [Addresses]");
        }

        public Address Select(IDbConnection connection, Guid locationId)
        {
            return connection.QuerySingle<Address>(
                @"SELECT [Id], [Address1], [Address2], [City], [State], [ZipCode], [SpecialDirections], [LocationId] FROM [Addresses] WHERE [LocationId] = @Id",
                new { Id = locationId }
            );
        }
    }
}
