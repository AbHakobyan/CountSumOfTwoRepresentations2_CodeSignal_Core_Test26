using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSumOfTwoRepresentations2_CodeSignal_Core_Test26
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = countSumOfTwoRepresentations2(93,24, 58);
            Console.WriteLine(n);
        }

        static int countSumOfTwoRepresentations2(int n, int l, int r)
        {
            if (2 * r < n || 2 * l > n) return 0;
            var min = Math.Max(l, n - r);
            var max = Math.Min(r, n - l);
            var mid = Math.Floor(((decimal)max + min) / 2);
            return (int)mid - min + 1;
            
        }
    }
}
