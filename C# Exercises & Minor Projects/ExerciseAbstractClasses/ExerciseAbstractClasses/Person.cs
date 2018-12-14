using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstractClasses
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
