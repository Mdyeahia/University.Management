using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data;
using University.Entities.Code;

namespace University.Service
{
    public class CodeService
    {
        #region Singleton
        public static CodeService Instance
        {
            get
            {
                if (instance == null) instance = new CodeService();

                return instance;
            }
        }
        private static CodeService instance { get; set; }

        private CodeService()
        {
        }

        #endregion
        UniversityDbContext context = new UniversityDbContext();
        public Designation GetDesignById(int Id)
        {
            return context.Designations.Find(Id);
        }
        public List<Designation> GetAllDesignation()
        {
            return context.Designations.ToList();
        }
    }
    
  
}
