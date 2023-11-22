using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DCI.Persistence
{
    public class RepositoryDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public RepositoryDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
        {
            //return new NpgsqlConnection(_connectionString);
            return new SqlConnection  (_connectionString);
        }

    }
}