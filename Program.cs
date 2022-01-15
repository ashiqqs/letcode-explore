using HackerrankSolution.InterviewPreparationKit;
using HackerrankSolution.InterviewPreparationKit.DictionaryHashmaps;
using HackerrankSolution.Leetcode.ArrayString;
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
            int[][] input = new int[1][];
            input[0] = new int[5] {1,2,3,4,5} ;
            //input[1] = new int[1] {2};
            //input[2] = new int[1] {3};
            //input[3] = new int[1] {4};

            var res = SpiralMatrix.SpiralOrder(input);

            foreach(int n in res)
            {
                Console.WriteLine(n);
            }

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
