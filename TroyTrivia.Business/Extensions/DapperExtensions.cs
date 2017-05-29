using System.Data;
using Dapper;

namespace TroyTrivia.Business.Extensions
{
    public static class DapperExtensions
    {
        public static int ExecuteNonQuery(this IDbConnection connection, string commandText, object param = null)
        {
            // Use Dapper to execute the given query
            return connection.Execute(commandText, param);
        }

        public static IDataReader ExecuteReaderQuery(this IDbConnection connection, string commandText, object param = null)
        {
            return connection.ExecuteReader(commandText, param);
        }

        public static T ExecuteScalarQuery<T>(this IDbConnection connection, string commandText, object param = null)
        {
            return connection.ExecuteScalar<T>(commandText, param);
        }
    }
}
