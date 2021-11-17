using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Code;

namespace University.Entities
{
    public class Teacher:BaseEntities
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Only positive number allowed")]
        [Display(Name = "Credit to be Taken")]
        public double CreditTaken { get; set; }
        public double CreditRemain { get; set; }


        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public int DesignationId { get; set; }
        public virtual Designation Designation { get; set; }
    }
}
