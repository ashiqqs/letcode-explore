using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class RemoveElement
    {
        public static int Remove(int[] nums, int val)
        {
            int k = 0, i;
            for(i=0; i<nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k++] = nums[i];
                }
            }
            return k;
        }

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int slowSum = 0, fastSum = 0, i;

            for(i=0; i<nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    if (slowSum < fastSum)
                    {
                        slowSum = fastSum; ;
                    }
                    fastSum = 0;
                }
                else
                {
                    fastSum++;
                }
            }
            if(slowSum > fastSum)
                return slowSum;
            return fastSum;
        }
    }
}