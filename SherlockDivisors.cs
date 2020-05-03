using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class SherlockDivisors
    {
        public static void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            int res = 1;
            if (n % 2==1) { Console.WriteLine(0);return; }
            for (long i=2; i<=Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    if (i % 2 == 0) { res++; }
                    if ((n / i) % 2 == 0) { res++; }
                    if (i == n / i) { res--; }
                }
            }
            Console.WriteLine(res);
        }
    }
}
