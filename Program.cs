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
            int[][] queries = new int[3][]
            {
                new int[3]{ 1,2,100}, new int[3]{ 2,5,100}, new int[3]{ 3,4,100},
            };

             Console.WriteLine(ArrayManipulation.GetMaxNum(5,queries));

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
