using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseExceptionHandling2
{
    public class LessThanOrEqualToZeroException : Exception
    {
        public LessThanOrEqualToZeroException() : base() { }
        public LessThanOrEqualToZeroException(string message) : base(message) { }
    }
}
