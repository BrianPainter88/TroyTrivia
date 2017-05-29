using System.Data;

namespace TroyTrivia.Business.Interfaces
{
    public interface IDatabase
    {
        IDbConnection GetDatabaseConnection();
    }
}
