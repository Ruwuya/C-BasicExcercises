using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicExcercises.Exercises.Exercise51_60
{
    public class Exercise54
    {
        // Find Century of year
        public static void FindCenturyOfYear()
        {
            int year = 2025;
            int century = (year + 99) / 100;
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Century: " + century);
        }
    }
}
