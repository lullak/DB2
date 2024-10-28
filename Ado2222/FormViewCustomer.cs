using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ado2222
{
    public partial class FormViewCustomer : Form
    {
        string sqlString = "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=SSPI;TrustServerCertificate=True;";
        public FormViewCustomer()
        {
            InitializeComponent();
        }
    }
}
