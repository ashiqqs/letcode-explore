using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class RotateArray
    {
        // [1, 2, 3, 4,5,6,7,8,9] 3
        public static void Rotate(int[] nums, int k)
        {
            int l = nums.Length;
            k = k % l;

            reverse(nums, l - k, l - 1);
            reverse(nums, 0, l - k - 1);
            reverse(nums, 0, l - 1);

            foreach (var r in nums)
            {
                Console.Write(r + ",");
            }

        }
        private static void reverse(int[] nums, int l, int h)
        {
            int temp, i, j;
            for(; l<h; l++, h--)
            {
                temp = nums[l];
                nums[l] = nums[h];
                nums[h] = temp;
            }
        }

        public static void TimeLimitexceed(int[] nums, int k)
        {
            int l = nums.Length;
            k = k % l;

            int i = 0, j = nums.Length - 1, x = 0, temp;
            for (; x < k; x++)
            {
                temp = nums[i];
                nums[i] = nums[j];
                while (i < j)
                {
                    nums[j--] = nums[j];
                    nums[j] = nums[++i];
                    nums[i] = temp;
                    temp = nums[j];
                }
                i = 0; j = nums.Length - 1;
            }
        }
    }

}
