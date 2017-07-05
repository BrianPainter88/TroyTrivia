using System;
using System.Collections.Generic;
using Dapper;
using Dapper.Contrib.Extensions;
using TroyTrivia.Business.Extensions;
using TroyTrivia.Business.Infrastructure;
using TroyTrivia.Business.Interactors;

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

        public Guid Insert(Guid locationId)
        {
            var sqlInteractor = new SqliteInteractor();

            var addressId = sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.ExecuteScalarQuery<Guid>(
                    @"INSERT INTO [Addresses] ([Id], [Address1], [Address2], [City], [State], [ZipCode], [SpecialDirections], [LocationId])
			VALUES (@Id, @Address1, @Address2, @City, @State, @ZipCode, @SpecialDirections, @LocationId)",
                    new
                    {
                        Id = Id,
                        Address1 = this.Address1,
                        Address2 = this.Address2,
                        City = this.City,
                        State = this.State,
                        ZipCode = this.ZipCode,
                        SpecialDirections = this.SpecialDirections,
                        locationId
                    }
                )
            );

            return addressId;
        }

        public void Update()
        {
            var sqlInteractor = new SqliteInteractor();

            sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.ExecuteNonQuery(
                    @"UPDATE [Addresses] SET [Address1] = @Address1, [Address2] = @Address2, [City] = @City, [State] = @State, [ZipCode] = @ZipCode, [SpecialDirections] = @SpecialDirections 
			WHERE [Id] = @AddressId",
                    new
                    {
                        Address1 = this.Address1,
                        Address2 = this.Address2,
                        City = this.City,
                        State = this.State,
                        ZipCode = this.ZipCode,
                        SpecialDirections = this.SpecialDirections,
                        AddressId = this.Id
                    }
                )
            );
        }

        public static IEnumerable<Address> Select()
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.Query<Address>(@"SELECT [Id], [Address1], [Address2], [City], [State], [ZipCode], [SpecialDirections] FROM [Addresses]")
            );
        }

        public Address Select(Guid locationId)
        {
            var sqlInteractor = new SqliteInteractor();

            return sqlInteractor.PerformDatabaseOperation((connection) =>
                connection.QuerySingle<Address>(
                    @"SELECT [Id], [Address1], [Address2], [City], [State], [ZipCode], [SpecialDirections], [LocationId] FROM [Addresses] WHERE [LocationId] = @Id",
                    new {Id = locationId}
                )
            );
        }
    }
}
