using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.InterviewPreparationKit
{
    public class ArrayManipulation
    {
        /// <summary>
        /// 1   2    3   4   5   6
        /// 100 0   -100 0   0   0
        /// 100 100 -100 0   0  -100
        /// 100 100  0   0  -100 0
        /// </summary>
        /// <param name="n"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public static long GetMaxNum(int n, int[][] queries)
        {
            int[] numbers = new int[n + 1];
            int i,length = queries.Length;
            for(i=0; i<length; i++)
            {
                numbers[queries[i][0]-1] += queries[i][2];
                numbers[queries[i][1]] -= queries[i][2];
            }
            long max = 0, sum = 0;
            for(i=0; i<n+1; i++)
            {
                sum += numbers[i];
                max = Math.Max(max, sum);
            }
            return max;
        }
    }
}
