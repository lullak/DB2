using System.Data;
using System.Data.SqlClient;
namespace DemoADOInsert

{
    public partial class FormInsert : Form
    {
        string connString = "Data Source=LULLAK\\MSSQLSERVER01;Initial Catalog=Northwind;Integrated Security=SSPI;TrustServerCertificate=True;";
        //localhost

        public FormInsert()
        {
            InitializeComponent();
            LoadEmployees();
        }

        public void LoadEmployees()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select employeeid, firstname + ' ' + lastname as fullname from employees";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                listBoxEmployee.DisplayMember = "fullname";
                listBoxEmployee.ValueMember = "employeeid";
                listBoxEmployee.DataSource = dataTable;

            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int id = (int)listBoxEmployee.SelectedValue;

            string sql = "delete from employees where employeeid = @employeeid";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@employeeid", id);
                cmd.ExecuteNonQuery();
            }

            LoadEmployees();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sql = "insert into Employees (LastName, FirstName) values (@lastname, @firstname)" +
                    "select cast(@@identity as int)";
                SqlCommand cmd =new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@firstname", firstName);
                cmd.Parameters.AddWithValue("@lastname", lastName);
                int id = (int) cmd.ExecuteScalar();
                
            }
            LoadEmployees();

        }
    }
}
