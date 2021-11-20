using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;
using University.Entities;

namespace University.Service
{
    public class StudentService
    {
        #region Singleton
        public static StudentService Instance
        {
            get
            {
                if (instance == null) instance = new StudentService();

                return instance;
            }
        }
        private static StudentService instance { get; set; }

        private StudentService()
        {
        }

        #endregion
        
        public bool EmailExist(string email)
        {
            UniversityDbContext context = new UniversityDbContext();
            return context.Students.Any(e => e.Email == email);
        }
        public string StudentRegNumber(Student student)
        {
            UniversityDbContext context = new UniversityDbContext();
            var deptName = DepartmentService.Instance.GetDepartbyId(student.DepartmentId);
            var first = deptName.Name;

            var second = DateTime.Now.Year.ToString();

            var count = context.Students.Count(s=>s.DepartmentId==student.DepartmentId &&s.Date.Year==student.Date.Year)+1;

            var third = count.ToString("000");

            return first+"-"+second+"-"+third;
        }
        public int StudentReg(int Id)
        {
            UniversityDbContext context = new UniversityDbContext();
            var student=context.Students.Find(Id-1).StudentRegNo;
            if (student == null)
            {
                return 1;
            }
            return int.Parse(student)+1;
        }
        public void SaveRegistration(Student student)
        {
            UniversityDbContext context = new UniversityDbContext();
            context.Students.Add(student);
            context.SaveChanges();
        }
    }
}
