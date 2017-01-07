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
    public class Address
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string SpecialDirections { get; set; }

        public void Insert(IDbConnection connection, int locationId)
        {
            connection.ExecuteNonQuery(
                @"INSERT INTO [Addresses] ([Address1], [Address2], [City], [State], [ZipCode], [SpecialDirections])
			VALUES (@Address1, @Address2, @City, @State, @ZipCode, @SpecialDirections)",
                new { Address1 = this.Address1, Address2 = this.Address2, City = this.City, State = this.State, ZipCode = this.ZipCode, SpecialDirections = this.SpecialDirections }
            );
        }

        public void Update(IDbConnection connection)
        {
            connection.ExecuteNonQuery(
                @"UPDATE [Addresses] SET [Address1] = @Address1, [Address2] = @Address2, [City] = @City, [State] = @State, [ZipCode] = @ZipCode, [SpecialDirections] = @SpecialDirections 
			WHERE [Id] = @AddressId",
                new { Address1 = this.Address1, Address2 = this.Address2, City = this.City, State = this.State, ZipCode = this.ZipCode, SpecialDirections = this.SpecialDirections, AddressId = this.Id }
            );
        }

        public IEnumerable<Address> Select(IDbConnection connection)
        {
            return connection.Query<Address>(@"SELECT [Id], [Address1], [Address2], [City], [State], [ZipCode], [SpecialDirections] FROM [Addresses]");
        }

        public Address Select(IDbConnection connection, int locationId)
        {
            return connection.QuerySingle<Address>(
                @"SELECT [Id], [Address1], [Address2], [City], [State], [ZipCode], [SpecialDirections] FROM [Addresses] WHERE [_LocationId] = @LocationId",
                new { LocationId = locationId }
            );
        }
    }
}
