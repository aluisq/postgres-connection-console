using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using postgres_console_application.models;
using Npgsql;


namespace postgres_console_application.services
{
    internal class CampanhaService
    {

        public static async Task<List<Campanha>> getAllCampanhasAsync()
        {

            List<Campanha> campanhas = new List<Campanha>();

            using NpgsqlConnection conn = PostgresConnection.getConnection();

            await conn.OpenAsync();

            var query = "select * from campanha";

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                Campanha campanha = new Campanha();
                
                campanha.Id = dr.GetInt32(0);
                campanha.NomeCampanha = dr.GetString(8);


                campanhas.Add(campanha);
            
            }

            dr.Close();
            conn.Close();

            return campanhas;

        }

    }
}
