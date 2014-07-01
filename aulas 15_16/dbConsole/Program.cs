using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbConsole {
    class Program {
        static void Main(string[] args) {
            SqlConnection con = new SqlConnection();
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();
            try {
                con.ConnectionString = "Server=localhost;Database=LP_DB;Trusted_Connection=Yes;";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [pessoa]";
                cmd.Connection = con;
                con.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    Console.WriteLine("ID: {0} | NOME: {1} | DATA NASC.: {2} | ALTURA: {3}",
                        reader.GetInt32(0), reader.GetString(1).TrimEnd(), reader.GetDateTime(2).ToShortDateString(), reader.GetInt32(3));
                }

            } catch (Exception ex){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);

            } finally {
                if (con.State == System.Data.ConnectionState.Open) {
                    con.Close();
                    con.Dispose();
                }
                cmd.Dispose();
                reader.Close();
                reader.Dispose();

            }
            Console.Read();
        }
    }
}
