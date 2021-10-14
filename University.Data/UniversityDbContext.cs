using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities;

namespace University.Data
{
    public class UniversityDbContext:DbContext
    {
        public UniversityDbContext() : base("UniversityConnection")
        {
            
        }
        public DbSet<Department> Departments { get; set; }

        public static UniversityDbContext Create()
        {
            return new UniversityDbContext();
        }
    }
}
