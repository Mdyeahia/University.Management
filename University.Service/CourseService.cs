using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;
using University.Entities;

namespace University.Service
{
    public class CourseService
    {
        #region Singleton
        public static CourseService Instance
        {
            get
            {
                if (instance == null) instance = new CourseService();

                return instance;
            }
        }
        private static CourseService instance { get; set; }

        private CourseService()
        {
        }

        #endregion
        UniversityDbContext context = new UniversityDbContext();

        public List<Course> FilterCoursebyDeptId(int Id)
        {
            return context.Courses.Where(x => x.DepartmentId == Id).ToList();
        }
        public string CourseName(string code)
        {
            var courseName = context.Courses.Where(x => x.Code == code).First();
           
            return courseName.Name; ;
        }
        public decimal CourseCredit(string code)
        {
            var courseName = context.Courses.Where(x => x.Code == code).First();
            
            return courseName.Credit;
        }
        public List<Course> AllCourses()
        {
            return context.Courses.ToList();
        }
        public void SaveCourse(Course course)
        {


            context.Courses.Add(course);
            context.SaveChanges();
        }
        public void UpdateCourse(Course course)
        {

            context.Entry(course).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public Course GetCourseById(int Id)
        {
            return context.Courses.Find(Id);
        }
    }
}
