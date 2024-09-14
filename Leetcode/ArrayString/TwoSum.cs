using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class ArrayString
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int idx1 = 0, idx2 = 1;
            int possibleIdx = idx2;
            int sum = numbers[idx1] + numbers[idx2], pairSum = 0;

            if (sum == target)
            {
                return new int[] { idx1 + 1, idx2 + 1 };
            }
            for(int i=2; i < numbers.Length; i++)
            {
                if ((numbers[i] + sum) > sum)
                {
                    possibleIdx = i-1;
                    idx2 = i-1;
                    break;
                }
                else
                {
                    sum+=numbers[i];
                }
            }

            while (pairSum != target)
            {
                pairSum = numbers[idx1] + numbers[idx2++];
                if (pairSum == target)
                {
                    break;
                }
                if (idx2 == numbers.Length)
                {
                    idx1++;
                    if (idx1 == possibleIdx)
                    {
                        possibleIdx = idx1+1;
                    }
                    idx2 = possibleIdx;
                    
                }
            }

            return new int[] { idx1+1, idx2};
        }
    }
}

