using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class Sorting
    {
        public static void Bubble()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), n => int.Parse(n));
            for(int i=1; i<numbers.Length; i++)
            {
                int j = numbers.Length - i;
                int k = 0;
                while (k<j)
                {
                    if (numbers[k] > numbers[k + 1])
                    {
                        int temp = numbers[k];
                        numbers[k] = numbers[k + 1];
                        numbers[k + 1] = temp;
                    }
                    k++;
                }
            }
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
        }
    }
}
