using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore_3.Entities
{
    public class PartTimeEmployee:Employee
    {
        public int NumberOfHours { get; set; }
        public double HourRate { get; set; }
    }
}
