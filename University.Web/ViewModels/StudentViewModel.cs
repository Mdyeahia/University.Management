using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Entities;

namespace University.Web.ViewModels
{
    public class StudentRegisterViewModel
    {
        public string Name { get; set; }

        [Required()]
        [EmailAddress()]
        [Remote("IsEmailExists", "Student", ErrorMessage = "Email already exists!")]
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

        public string StudentRegNo { get; set; }

        public List<Department> departmentList { get; set; }

        
    }
}