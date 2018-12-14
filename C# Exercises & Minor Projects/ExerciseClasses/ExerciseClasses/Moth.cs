using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClasses
{
    public class Moth
    {
        public int DoItMothy(int num1)
        {
            return num1 * 72 - 53;
        }
        public int DoItMothy(decimal deci1)
        {
            return Convert.ToInt32((deci1 / 2.0m) + 800.0m);
        }
        public int DoItMothy(string str1)
        {
            return (Convert.ToInt32(str1) * 800 - 800);
        }
    }
}
