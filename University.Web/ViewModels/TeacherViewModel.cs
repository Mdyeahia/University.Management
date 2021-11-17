using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Entities;
using University.Entities.Code;

namespace University.Web.ViewModels
{
    public class TeacherViewModelCreate
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public int Credit { get; set; }

        public int DeptId { get; set; }
        public Department Department { get; set; }
        public List<Department> departments { get; set; }

        public int DesignId { get; set; }
        public Designation Designation { get; set; }
        public List<Designation> designations { get; set; }
    }
    public class TeacherListingViewModel
    {
        public  List<Teacher> teachers { get; set; }
    }
}