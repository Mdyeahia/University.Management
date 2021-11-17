using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Entities
{
    public class Department: BaseEntities
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual  List<Teacher> Teachers { get; set; }
        public virtual  List<Course> Courses { get; set; }
    }
}
