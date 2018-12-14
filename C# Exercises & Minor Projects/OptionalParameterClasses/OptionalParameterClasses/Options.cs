using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterClasses
{
    public class Options
    {
        public int MultTwo(int num1, int num2 = 5)
        {
            return num1 * num2;
        }
    }
}
