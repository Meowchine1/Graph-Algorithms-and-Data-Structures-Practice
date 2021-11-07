using System;
using System.Collections.Generic;
using System.Text;

namespace AtdGraph
{
    public class Edje : IComparable<Edje>
    {
        public string start;
        public string end;
        public double weight;
        public int CompareTo(Edje x)
        {
            if (weight < x.weight)
            {
                return -1;
            }
            if (weight > x.weight)
            {
                return 1;
            }
            return 0;
        }
    }
}
