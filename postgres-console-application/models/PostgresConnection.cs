using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace postgres_console_application.models
{
    internal class PostgresConnection
    {
        public static NpgsqlConnection getConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User id=postgres;Password=root;Database=postgres");

        }

    }
}
