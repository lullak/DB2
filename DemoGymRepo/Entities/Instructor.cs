using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGymRepo.Entities
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string InstructorName { get; set; }

        public Instructor(int instructorID, string instructorName)
        {
            InstructorID = instructorID;
            InstructorName = instructorName;
        }
    }
}
