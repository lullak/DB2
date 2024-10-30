using Ado3.Repository;

namespace Ado3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMember();
        }

        private void LoadMember()
        {

            MemberRepo repo = new MemberRepo();
            var result = repo.GetList();

            listBox1.DisplayMember = "ToString";
            listBox1.ValueMember = "MemberID";
            listBox1.DataSource = result;
        }
    }
}
