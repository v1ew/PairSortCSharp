using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsSort
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Pair<string, string>("two", "three"));
            list.Add(new Pair<string, string>("one", "two"));
            list = StaticSort.sort(list);
            foreach (Pair<string, string> pair in list)
            {
                Console.WriteLine(pair.ToString());
            }
        }
    }
}
