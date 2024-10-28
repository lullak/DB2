using System.Data;
using System.Data.SqlClient;

namespace Ado1
{
    public partial class FormAdo1 : Form
    {
        public FormAdo1()
        {
            InitializeComponent();
            LoadAllEmployees();
        }

        public void LoadAllEmployees()
        {
            string connString = "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI;TrustServerCertificate=True;";

            DataTable dataTable = new DataTable();

            using(SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select employeeid, firstname, lastname from employees";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dataTable);
            }
            dataTable.Columns.Add("FullName", typeof(string), "firstname + ' ' + lastname");
            listBoxEmp.DisplayMember = "FullName";
            listBoxEmp.ValueMember = "employeeid";
            listBoxEmp.DataSource = dataTable;
        }
    }
}
