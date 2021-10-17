using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Entities
{
    public class AssignCourse:BaseEntities
    {
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }


        public decimal CreditTaken { get; set; }
        public decimal CreditRemain { get; set; }


        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string CourseName { get; set; }
        public decimal CourseCredit { get; set; }
    }
}
