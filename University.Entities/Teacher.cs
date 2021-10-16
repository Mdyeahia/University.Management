using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Code;

namespace University.Entities
{
    public class Teacher:BaseEntities
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public int Credit
        {
            get { return Credit; }
            set
            {
                if (value >= 0)
                    Credit = value;
                else
                    Credit = 0;
            }
        }

        public Department Department { get; set; }
        public Designation Designation { get; set; }
    }
}
