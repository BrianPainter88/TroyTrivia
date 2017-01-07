using System.Data;
using System.Data.SQLite;
using System.IO;
using TroyTrivia.Business.Extensions;
using TroyTrivia.Business.Infrastructure;
using TroyTrivia.Business.Interfaces;

namespace TroyTrivia.Business.Interactors
{
    public class SQLiteInteractor : IDatabase
    {
        private readonly string _sqlDatabaseFilePath;

        public SQLiteInteractor()
        {
            _sqlDatabaseFilePath = Properties.Settings.Default.DatabaseFilePath;
            CreateDatabaseIfNotExists(_sqlDatabaseFilePath);
        }

        public SQLiteInteractor(string sqlDatabseFilePath)
        {
            _sqlDatabaseFilePath = sqlDatabseFilePath;
            CreateDatabaseIfNotExists(_sqlDatabaseFilePath);
        }

        public void CreateDatabaseIfNotExists(string databaseFilePath)
        {
            if (false == File.Exists(_sqlDatabaseFilePath))
            {
                SQLiteConnection.CreateFile(_sqlDatabaseFilePath);

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

                    foreach (var commandText in BaseTableStructure.baseTableData)
                    {
                        database.ExecuteNonQuery(commandText);
                    }
                });
        }

        public IDbConnection GetDatabaseConnection()
        {
            return new SQLiteConnection($"Data Source={_sqlDatabaseFilePath};Version=3;");
        }
    }
}
