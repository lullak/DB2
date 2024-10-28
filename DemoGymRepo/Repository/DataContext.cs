using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace DemoGymRepo.Repository
{
    //Detta är en generell klass där man vill kapsla in ADO.Net
    public static class DataContext
    {
        private static readonly string _connString = "Data Source=localhost;Initial Catalog=GymDB;Integrated Security=SSPI;TrustServerCertificate=True;";
   
        //Metod Hantera select. Retunerar en datatable
        public static DataTable ExecuteQueryReturnTable(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                foreach (SqlParameter parameter in parameters) 
                {
                    cmd.Parameters.Add(parameter);
                }

                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        //Metod Hantera Insert,update och delete. Retunerar inget

        public static void ExecuteNonQuery(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }

                cmd.ExecuteNonQuery();
            }
        }
    
    }
}
