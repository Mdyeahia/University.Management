using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities.Code;

namespace University.Entities
{
    public class Course:BaseEntities
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Credit { get; set; }
        public string Description { get; set; }

        public virtual Department Department { get; set; }



        [Column("Semester")]
        public string SemesterString
        {
            get { return Semester.ToString(); }
            set
            {
                if (Enum.TryParse(value, out Semester newValue))
                { Semester = newValue; }
            }
        }

        [NotMapped]
        public virtual Semester Semester { get; set; }
    }
}
