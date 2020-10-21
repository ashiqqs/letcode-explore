using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.InterviewPreparationKit
{
    public class MinimumSwap
    {
        public static int GetMinSwap(int[] numbers)
        {
            int minSwap = 0;
            int length = numbers.Length, temp;
            for (int i = 0; i < length; i++)
            {
                if (numbers[i] == i + 1) { continue; }
                temp = numbers[i];
                numbers[i] = numbers[numbers[i] - 1];
                numbers[temp - 1] = temp;
                i--;
                minSwap++;
            }
            return minSwap;

        }
    }
}
