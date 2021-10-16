using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities;
using University.Entities.Code;

namespace University.Data
{
    public class UniversityDbContext:DbContext
    {
        public UniversityDbContext() : base("UniversityConnection")
        {
            
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Designation> Designations { get; set; }




        public static UniversityDbContext Create()
        {
            return new UniversityDbContext();
        }
    }
}
