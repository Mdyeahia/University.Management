using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Entities;

namespace University.Web.ViewModels
{
    public class AssignCourseViewModelCreate
    {
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int TeacherId { get; set; }
        public  Teacher Teacher { get; set; }


        public double CreditTaken { get; set; }
        public double CreditRemain { get; set; }


        public int CourseId { get; set; }
        public  Course Course { get; set; }

        public string CourseName { get; set; }
        public double CourseCredit { get; set; }
    }
    public class AssignCourseFillterViewModel
    {
        public List<Department> departments { get; set; }
        public List<Teacher> teachers { get; set; }
        public List<Course> courses { get; set; }
        public double CreditTaken { get; set; }
        public double CreditRemain { get; set; }
        public string CourseName { get; set; }
        public double CourseCredit { get; set; }


        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        
    }
}