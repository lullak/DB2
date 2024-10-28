using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGymRepo.Entities
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Member(int memberID, string memberName, string email, string phone)
        {
            MemberID = memberID;
            MemberName = memberName;
            Email = email;
            Phone = phone;
        }
    }
}
