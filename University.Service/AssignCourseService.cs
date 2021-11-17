using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;
using University.Entities;
using System.Data.Entity;

namespace University.Service
{
    public class AssignCourseService
    {
        #region Singleton
        public static AssignCourseService Instance
        {
            get
            {
                if (instance == null) instance = new AssignCourseService();

                return instance;
            }
        }
        private static AssignCourseService instance { get; set; }

        private AssignCourseService()
        {
        }

        #endregion
        
        
        public double CreditTook(int Id)
        {
            UniversityDbContext context = new UniversityDbContext();
            var assigncourse = context.AssignCourses.Where(x=>x.TeacherId==Id).First();
            var value = assigncourse.CreditTaken;
            return value;
        }
        
        public List<Teacher> GetTeacherbydeptId(int Id)
        {
            UniversityDbContext context = new UniversityDbContext();
            context.Configuration.ProxyCreationEnabled = false;

            return context.Teachers.Where(t => t.DepartmentId == Id).Where(t=>t.CreditRemain > 0).ToList();
        }
        public List<Course> GetCbydId(int Id)
        {
            UniversityDbContext context = new UniversityDbContext();
            context.Configuration.ProxyCreationEnabled = false;

            return context.Courses.Where(c => c.DepartmentId == Id).ToList();
        }
        public Teacher TeacherById(int Id)
        {
            UniversityDbContext context = new UniversityDbContext();
            context.Configuration.ProxyCreationEnabled = false;
            return context.Teachers.Find(Id);
        }
        public Course CourseById(int Id)
        {
            UniversityDbContext context = new UniversityDbContext();
            context.Configuration.ProxyCreationEnabled = false;
            return context.Courses.Find(Id);
        }
        public void SaveAssignCourse(AssignCourse Course)
        {
            UniversityDbContext context = new UniversityDbContext();
            context.AssignCourses.Add(Course);
            context.SaveChanges();
        }
        


    }
}
