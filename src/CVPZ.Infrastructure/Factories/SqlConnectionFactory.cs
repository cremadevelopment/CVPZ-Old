using Microsoft.Data.SqlClient;

namespace CVPZ.Infrastructure.Factories
{
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly string connectionString;

        public SqlConnectionFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public SqlConnection SqlConnection()
        {
            return new SqlConnection(this.connectionString);
        }
    }
}
