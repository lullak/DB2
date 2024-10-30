using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado3.Repository
{
    public static class DataContext
    {
        private static readonly string _conn = "Data Source=LULLAK\\MSSQLSERVER01;Initial Catalog=GymDB;Integrated Security=SSPI;TrustServerCertificate=True;";
        
        public static DataTable ExecuteQueryReturnTable(string sql,List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (SqlParameter p in parameters)
                {
                    cmd.Parameters.Add(p);
                }   
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static void ExecuteNonQuery(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                foreach(SqlParameter p in parameters)
                {
                    cmd.Parameters.Add(p);
                }
                cmd.ExecuteNonQuery();
            }
        }
    
    }
}
