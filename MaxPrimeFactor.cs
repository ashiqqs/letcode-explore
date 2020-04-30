using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class MaxPrimeFactor
    {
        private static bool isPrime(long n)
        {
            long i;
            for (i=2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) { return false; }
            }
            return i==n/2+1;
        }
        public static void Execute()
        {
            long.TryParse(Console.ReadLine(), out long n);
            double factorsProduct = 1;
            int maxFactor = 0;
            for (long i = 2; i <= n; i++)
            {
                if (isPrime(i))
                {
                    factorsProduct *= i;
                    if (factorsProduct <= n)
                    {
                        maxFactor++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(maxFactor);
        }
    }
}
