using System.Data;
using System.Data.SqlClient;

namespace ADOGrunder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAllCustomers();
        }
        
        private void LoadAllCustomers()
        {
            // Detta �r addressen till servern och databasen som vi ska anv�nda.
            string connString = "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI;TrustServerCertificate=True;";
           
            DataTable result = new DataTable();
            //1. skapa en uppkoppling
            using(SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select customerid, companyname from customers";

                //2. skapa en anrop �ver den uppkoppling som finns
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(result);
            }

            listBoxCustomers.DisplayMember = "companyname";
            listBoxCustomers.ValueMember = "customerid";
            listBoxCustomers.DataSource = result;

        }
    }
}
