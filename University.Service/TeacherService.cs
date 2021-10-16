using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;
using University.Entities;

namespace University.Service
{
    public class TeacherService
    {
        #region Singleton
        public static TeacherService Instance
        {
            get
            {
                if (instance == null) instance = new TeacherService();

                return instance;
            }
        }
        private static TeacherService instance { get; set; }

        private TeacherService()
        {
        }

        #endregion
        UniversityDbContext context = new UniversityDbContext();
        public void SaveTeacher(Teacher teacher)
        {
            context.Teachers.Add(teacher);
            context.SaveChanges();
        }
        public List<Teacher> GetAllTeacher()
        {
            return context.Teachers.ToList();
        }
    }
}
