using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class BestDivisor
    {
        private static int GetBestDivisor(int n)
        {
            int result = 0;
            int sumOfDigit = 0;
            for(int i=1; i<=n; i++)
            {
                if (n % i == 0)
                {
                    int currentSumOfDigit = GetSumOfDigit(i);
                    if (sumOfDigit == currentSumOfDigit)
                    {
                        if (i > result)
                        {
                            result = i;
                            sumOfDigit = currentSumOfDigit;
                        }
                    }
                    else
                    {
                        if (currentSumOfDigit > sumOfDigit)
                        {
                            result = i;
                            sumOfDigit = currentSumOfDigit;
                        }
                    }
                }
            }
            return result;
        }

        private static int GetSumOfDigit(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }
        public static void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetBestDivisor(n));
        } 
    }
}
