using ConsolePostgresConnection.services;
using Npgsql;

var connectionString = "Server=localhost;Port=5432;Database=test;Username=postgres;Password=root";

//await using var conn = new NpgsqlConnection(connectionString);

var pg = new PostgresConnection();

var conn = await pg.getConnectionAsync(connectionString);

// Retrieve all rows
await using var cmd = new NpgsqlCommand(@"Select * from Pokemon", conn );

await using var reader = await cmd.ExecuteReaderAsync();

while (await reader.ReadAsync())
{
    Console.WriteLine(reader.GetInt64(0) + " - " +reader.GetString(1));
}


