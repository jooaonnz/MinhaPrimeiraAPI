using MySql.Data.MySqlClient;

namespace MinhaPrimeiraAPI.Contracts.Infrastructure
{
    public interface IConnection
    {
        MySqlConnection GetConnection();

        Task<int> Execute(string sql, object obj);
    
    }
}
