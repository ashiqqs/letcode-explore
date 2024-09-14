using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class RemoveDuplicate
    {
        public static int Remove(int[] nums)
        {
            int k = 0, num = nums[k];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != num)
                {
                    nums[++k] = nums[i];
                    num = nums[i];
                }
            }

            return k + 1;
        }

        public static void RemoveZero(int[] nums)
        {
            if(nums.Length == 0)
            {
                return;
            }

            int zeroIdx = 0;
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[zeroIdx++] = nums[i];
                }
            }

            for(int i=zeroIdx; i<nums.Length; i++)
            {
                nums[i] = 0;
            }

        }
    }
}
