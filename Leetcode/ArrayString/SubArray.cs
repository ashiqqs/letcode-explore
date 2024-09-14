using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class SubArray
    {
        public static int MinLen(int target, int[] nums)
        {
            int minL = 0, count = 0;
            double sum = 0;
            int back = 0, next = 0;
            bool found = false;

            while(next<nums.Length)
            {
                sum += nums[next];
                count++;
                if (sum >= target)
                {
                    if (!found)
                    {
                        minL = count;
                        found = true;
                    }
                    while ((sum - nums[back]) >= target)
                    {
                        sum -= nums[back];
                        count--;
                        back++;
                    }
                    if (minL > count)
                    {
                        minL = count;
                    }
                }
                next++;
            }

            return found?minL:0;
        }
    }
}
