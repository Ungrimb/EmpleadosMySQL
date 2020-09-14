using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EmpleatMySql.Models
{
    public class EmpleatContext
    {

        public string ConnectionString { get; set; }

        public EmpleatContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Empleat> GetAll()
        {
            List<Empleat> list = new List<Empleat>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM empleat", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Empleat()
                        {
                            Id = reader.GetInt32("Id"),
                            Nom = reader.GetString("Nom"),
                            Cognom = reader.GetString("Cognom"),
                            Càrrec = reader.GetString("Càrrec"),
                            Sou = reader.GetString("Sou")
                        });
                    }
                }
            }

            return list;
        }

    }
}
