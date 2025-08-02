using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Example01Interface
{
    internal class SeriesOne : ISeries
    {
        public int Current { get ; set ; }

        public void GetNextValue()
        {
            Current += 2; // Incrementing the current value by 1
        }
    }
}
