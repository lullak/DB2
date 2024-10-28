using DemoGymRepo.Entities;
using DemoGymRepo.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DemoGymRepo
{
    public partial class FormInstructor : Form
    {
        public FormInstructor()
        {
            InitializeComponent();
            LoadInstructors();
        }

        private void LoadInstructors()
        {

            InstructorRepo repo = new InstructorRepo();
            var result = repo.GetList();

            listBoxInstructorName.DisplayMember = "instructorName";
            listBoxInstructorName.ValueMember = "instructorID";
            listBoxInstructorName.DataSource = result;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            InstructorRepo repo = new InstructorRepo();
            repo.Save(new Instructor(0, textBoxName.Text));

            LoadInstructors();
        }
    }
}
