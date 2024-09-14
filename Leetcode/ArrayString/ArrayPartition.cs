using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class ArrayPartition
    {
        public static int Partition(int[] nums)
        {
            int sum = 0;

            Array.Sort(nums);

            for(int i = 0; i < nums.Length; i = i + 2)
            {
                sum+=nums[i];
            }
            return sum;
        }
    }
}
