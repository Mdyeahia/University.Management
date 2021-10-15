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
        public List<Course> AllCourses()
        {
            return context.Courses.ToList();
        }
        public void SaveCourse(Course course)
        {


            context.Courses.Add(course);
            context.SaveChanges();
        }
    }
}
