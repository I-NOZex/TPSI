using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo2DLL {
    class DB {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public DB(string host,string dbname){
            con.ConnectionString = string.Format("Server={0};Database={1};Trusted_Connection=Yes;",host,dbname);
        }

        public SqlDataReader select(string table, string columns = "*", string extra = "") {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = string.Format("SELECT {0} FROM {1} {2}",columns,table,extra);
                cmd.Connection = con;
                con.Open();
                return cmd.ExecuteReader();
        }

        public int insert(string table, string columns, string values) {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = string.Format("INSERT INTO [{0}]({1}) VALUES({2})", table, columns, values);
            cmd.Connection = con;
            con.Open();
            if (cmd.ExecuteNonQuery() < 1)
                throw new Exception("Nenhum registo inserido.");
            else {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = string.Format("SELECT IDENT_CURRENT('{0}')",table);
                return cmd.ExecuteReader().GetInt32(0);
            }
            
        }

        public void close() {
            if (con.State == System.Data.ConnectionState.Open) {
                con.Close();
                con.Dispose();
            }
            cmd.Dispose();
        }
    }
}
