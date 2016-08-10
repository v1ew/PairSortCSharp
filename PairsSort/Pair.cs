using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsSort
{
    public class Pair<F, S>
    {
        public Pair(F first, S second)
        {
            First = first;
            Second = second;
        }

        public string ToString()
        {
            return First.ToString() + " " + Second.ToString();
        }

        public F First { get; private set; }
        public S Second { get; private set; }
    }
}
