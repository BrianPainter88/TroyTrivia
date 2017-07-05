using System.Data;
using System.Data.SQLite;
using System.IO;
using TroyTrivia.Business.Extensions;
using TroyTrivia.Business.Infrastructure;
using TroyTrivia.Business.Interfaces;

namespace TroyTrivia.Business.Interactors
{
    public class SqliteInteractor : IDatabase
    {
        private readonly string _sqlDatabaseFilePath = Properties.Settings.Default.DatabaseFilePath;

        public SqliteInteractor()
        {
            CreateDatabaseIfNotExists(_sqlDatabaseFilePath);
        }

        public SqliteInteractor(string sqlDatabaseFilePath)
        {
            _sqlDatabaseFilePath = sqlDatabaseFilePath;
            CreateDatabaseIfNotExists(_sqlDatabaseFilePath);
        }

        public void CreateDatabaseIfNotExists(string databaseFilePath)
        {
            if (false == File.Exists(databaseFilePath))
            {
                SQLiteConnection.CreateFile(databaseFilePath);

                CreateBaseTableStructure();
            }
        }

        public void CreateBaseTableStructure()
        {
            this.PerformDatabaseOperation((database) =>
                {
                    foreach (var commandText in BaseTableStructure.baseTables)
                    {
                        database.ExecuteNonQuery(commandText);
                    }

                    /*
                    foreach (var commandText in BaseTableStructure.baseTableData)
                    {
                        database.ExecuteNonQuery(commandText);
                    }
                    */
                });
        }

        public IDbConnection GetDatabaseConnection()
        {
            return new SQLiteConnection($"Data Source={_sqlDatabaseFilePath};Version=3;");
        }
    }
}
