using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace University.Entities
{
    public class Student:BaseEntities
    {
        public string Name { get; set; }

        [Required()]
        [EmailAddress()]
        [Remote("IsEmailExists", "Student", HttpMethod = "POST", ErrorMessage = "Email already exists!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required()]
        [Phone]
        public string ContactNo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public string StudentRegNo { get;set; }
    }
}
