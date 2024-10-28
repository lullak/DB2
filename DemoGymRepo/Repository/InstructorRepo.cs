using DemoGymRepo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGymRepo.Repository
{
    public class InstructorRepo
    {
        public void Save(Instructor instructor)
        {
            string sql = "insert into instructor(instructorname) values (@instructorname)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@instructorname", instructor.InstructorName));
            DataContext.ExecuteNonQuery(sql, parameters);
        }

        public List<Instructor> GetList() 
        {
            string sql = "select instructorid, instructorname from instructor";

            //Eftersom det inte finns några parametrar skickar vi in en tom lista
            DataTable data = DataContext.ExecuteQueryReturnTable(sql, new List<SqlParameter>());

            //Här måste data mappas med instructor
            List<Instructor> instructors = new List<Instructor>();
            foreach (DataRow row in data.Rows) 
            {
                instructors.Add(new Instructor((int)row.ItemArray[0], row.ItemArray[1].ToString()));
            }

            return instructors;
        }
    }
}
