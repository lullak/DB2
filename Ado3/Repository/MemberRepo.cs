using Ado3.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado3.Repository
{
    public class MemberRepo
    {

        public List<Member> GetList()
        {
            string sql = "select MemberID, MemberName, Email, Phone from Member";

            DataTable data = DataContext.ExecuteQueryReturnTable(sql, new List<SqlParameter>());

            List<Member> members = new List<Member>();
            foreach (DataRow row in data.Rows)
            {
                members.Add(new Member(
                    (int)row["MemberID"], 
                    row["MemberName"].ToString(), 
                    row["Email"].ToString(), 
                    row["Phone"].ToString()
                    ));
            }

            return members;
        }
    }
}
