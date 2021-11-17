using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;
using University.Entities;

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
        UniversityDbContext context = new UniversityDbContext();
        
        public double CreditTook(int Id)
        {
            var assigncourse = context.AssignCourses.Where(x=>x.TeacherId==Id).First();
            var value = assigncourse.CreditTaken;
            return value;
        }
        public List<Teacher> GetTeacherbydeptId(int Id)
        {

            context.Configuration.ProxyCreationEnabled = false;
            return context.Teachers.Where(t => t.DepartmentId == Id).ToList();
        }
        public List<Course> GetCbydId(int Id)
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Courses.Where(c => c.DepartmentId == Id).ToList();
        }
        public Teacher TeacherById(int Id)
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Teachers.FirstOrDefault(t => t.Id == Id);
        }
        public Course CourseById(int Id)
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Courses.FirstOrDefault(t => t.Id == Id);
        }
        public void SaveAssignCourse(AssignCourse assignCourse)
        {
            
            context.AssignCourses.Add(assignCourse);
            context.SaveChanges();
        }
        

    }
}
