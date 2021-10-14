using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;
using University.Entities;

namespace University.Service
{
    public class DepartmentService
    {
        #region Singleton
        public static DepartmentService Instance
        {
            get
            {
                if (instance == null) instance = new DepartmentService();

                return instance;
            }
        }
        private static DepartmentService instance { get; set; }

        private DepartmentService()
        {
        }

        #endregion
        UniversityDbContext context = new UniversityDbContext();
        public List<Department> AllDepartments()
        {
            return context.Departments.ToList();
        }
        public void SaveDept(Department dept)
        {
            

            context.Departments.Add(dept);
            context.SaveChanges();
        }
    }  
}
