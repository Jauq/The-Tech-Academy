using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseConstantsAndChainedConstructors
{
    public class ChainMe
    {
        public ChainMe(bool doIt) : this(doIt, 1)
        {
        }
        public ChainMe(bool doIt, int times)
        {
            DoIt = doIt;
            Times = times;
        }
        public int Times { get; set; }
        public bool DoIt { get; set; }
    }
}
