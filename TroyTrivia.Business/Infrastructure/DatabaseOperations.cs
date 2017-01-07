using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TroyTrivia.Business.Extensions;
using TroyTrivia.Business.Interfaces;

namespace TroyTrivia.Business.Infrastructure
{
    public static class DatabaseOperations
    {
        public static TResult PerformDatabaseOperation<TResult>(this IDatabase database, Func<IDbConnection, TResult> executableFunction)
        {
            TResult result;
            using (var connection = database.GetDatabaseConnection())
            {
                OpenConnectionIfValid(connection);

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        result = executableFunction(connection);
                    }
                    catch (Exception ex)
                    {
                        ex.GetAllExceptionMessages();
                        throw;
                    }
                    finally
                    {
                        transaction.Commit();
                        CloseConnection(connection);
                    }
                }
            }

            return result;
        }

        public static void PerformDatabaseOperation(this IDatabase database, Action<IDbConnection> executableFunction)
        {
            using (var connection = database.GetDatabaseConnection())
            {
                OpenConnectionIfValid(connection);

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        executableFunction(connection);
                    }
                    catch (Exception ex)
                    {
                        ex.GetAllExceptionMessages();
                        throw;
                    }
                    finally
                    {
                        transaction.Commit();
                        CloseConnection(connection);
                    }
                }
            }
        }

        private static void OpenConnectionIfValid(IDbConnection connection)
        {
            // Ensure we have a connection
            if (connection == null)
            {
                throw new NullReferenceException("Please provide a connection");
            }

            // Ensure that the connection state is Open
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private static void CloseConnection(IDbConnection connection)
        {
            // Ensure that the connection state is Open
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
