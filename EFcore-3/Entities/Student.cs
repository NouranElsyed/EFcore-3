using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore_3.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();

    }
}
