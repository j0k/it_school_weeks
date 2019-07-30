using System;
using System.Collections.Generic;

namespace day02
{
    public class Alrorithms
    {
        private int pivot(List<int> a)
        {
            return a.Count / 2;
        }
        public List<int> quickSort(List<int> a)
        {
            if (a.Count <= 1)
                return a;

            int ind = pivot(a);
            int elem = a[ind];

            List<int> left  = new List<int>();// < elem
            List<int> right = new List<int>();// < elem
            for (int i=0; i < a.Count; i++)
            {
                int e = a[i];
                if (i == ind)
                    continue;

                if (e < elem)
                    left.Add(e);
                else
                    right.Add(e);
            }

            // left + [elem] + right

            List<int> res = new List<int>();
            res.AddRange(quickSort(left));
            res.Add(elem);
            res.AddRange(quickSort(right));
            return res;            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = { 1, 2, 3, 5, 6, 3, 2, 5, 6, 2,3,4,5,6,1,2,100,-100,1,2 };
            List<int> a = new List<int>();
            foreach (int e in b)
                a.Add(e);

            Alrorithms algo = new Alrorithms();
            a = algo.quickSort(a);

            Console.WriteLine(a);
            foreach (var v in a)
                Console.Write(v + " ");
            
            
        }
    }
}
