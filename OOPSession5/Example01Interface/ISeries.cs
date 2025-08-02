using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Example01Interface
{
    internal interface ISeries
    {
        public int Current { get; set; }
        public void GetNextValue();
        public void ResetSeries()
        {
            Current = 0; 
        }

    }
}
