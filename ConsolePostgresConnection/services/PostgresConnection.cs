using Npgsql;

namespace ConsolePostgresConnection.services
{
    class PostgresConnection
    {
        public async Task<NpgsqlConnection> getConnectionAsync(string connectionString)
        {
            var conn = new NpgsqlConnection(connectionString);

            await conn.OpenAsync();
            
            return conn;

        }

    }
}
