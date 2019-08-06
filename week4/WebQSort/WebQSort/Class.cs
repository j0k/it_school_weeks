using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebQSort
{

    public class Algorithms<T>
    {
        public static Random rnd = new Random();
        private static int pivot(List<T> a)
        {
            return rnd.Next(a.Count);
        }
        public static List<T> quickSort(List<T> a, Func<T,T,int> cmp)
        {
            if (a.Count <= 1)
                return a;

            int ind = pivot(a);
            T elem = a[ind];

            List<T> left = new List<T>();// < elem
            List<T> right = new List<T>();// < elem
            for (int i = 0; i < a.Count; i++)
            {
                T e = a[i];
                if (i == ind)
                    continue;

                int r = cmp(e, elem);
                if (r < 0)
                    left.Add(e);
                else
                    right.Add(e);
            }

            // left + [elem] + right

            List<T> res = new List<T>();
            res.AddRange(quickSort(left, cmp));
            res.Add(elem);
            res.AddRange(quickSort(right, cmp));
            return res;
        }
    }
}
