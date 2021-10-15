using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Entities;
using University.Entities.Code;

namespace University.Web.ViewModels
{
    public class CourseViewmodelsCreate
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Credit { get; set; }
        public string Description { get; set; }
        public int DeptId { get; set; }
        public Department department { get; set; }
        public List<Department> departments { get; set; }

        public string semesterString { get; set; }
        public Semester semester { get; set; }
        public List<Semester> semesters { get; set; }
    }
    public class CoursListingViewModel
    {
        public List<Course> courses { get; set; }
    }
}