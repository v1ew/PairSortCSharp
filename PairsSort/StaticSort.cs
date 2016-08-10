using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsSort
{
    public static class StaticSort
    {
        public static ArrayList sort(ArrayList list)
        {
            if (list == null || list.Count == 0) return list;
            ArrayList newList = new ArrayList();
            newList.Add(list[0]);
            list.RemoveAt(0);
            bool pairMoved;
            do
            {
                pairMoved = false;
                foreach (Pair<string, string> pair in list)
                {
                    if (((Pair<string, string>)newList[0]).First == pair.Second)
                    {
                        newList.Insert(0, pair);
                        pairMoved = true;
                        list.Remove(pair);
                        break;
                    }
                    else if (((Pair<string, string>)newList[newList.Count - 1]).Second == pair.First)
                    {
                        newList.Add(pair);
                        pairMoved = true;
                        list.Remove(pair);
                        break;
                    }
                }
            } while (list.Count > 0 && pairMoved);
            return newList;
        }
    }
}
