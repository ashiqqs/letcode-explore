using HackerrankSolution.InterviewPreparationKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    class Program
    {

        static void Main(string[] args)
        {
             Console.WriteLine(MinimumSwap.GetMinSwap(new int[]{ 7, 1, 3, 2, 4, 5, 6 }));

            Console.ReadKey();
        }
        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            else if (b == 0)
                return a;
            else
                return gcd(b%a,a);
        }
    }
}
