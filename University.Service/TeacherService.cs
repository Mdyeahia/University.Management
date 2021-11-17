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

        public List<Teacher> FilterTeacher(int? deptid)
        {
            return context.Teachers.Where(x => x.DepartmentId == deptid).ToList();
        }
        public double CreditTook(int Id)
        {
            var teacher = context.Teachers.Find(Id);
            var value = teacher.CreditTaken;
            return value;
        }
        

        public void SaveTeacher(Teacher teacher)
        {
            context.Teachers.Add(teacher);
            context.SaveChanges();
        }
        public void UpdateTeacher(Teacher teacher)
        {
            context.Entry(teacher).State=System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public List<Teacher> GetAllTeacher()
        {
            return context.Teachers.ToList();
        }
        public Teacher GetTeacherById(int Id)
        {
            return context.Teachers.Find(Id);
        }
    }
}
