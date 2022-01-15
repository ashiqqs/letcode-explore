using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class SpiralMatrix
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            
            List<int> res = new List<int>();
            if (m == 1)
            {
                foreach (int num in matrix[0])
                {
                    res.Add(num);
                }
                return res;
            }
            if (n==1)
            {
                foreach(int[] num in matrix)
                {
                    res.Add(num[0]);
                }
                return res;
            }

            int i = 0, j = 0, numOfItem = m*n;
            int maxR = n - 1, maxB = m - 1, minL = 0, minT = 1;
            bool right = true, bottom = false, left = false, top = false;

            while(res.Count()<numOfItem)
            {
                res.Add(matrix[i][j]);
                if(right && j < maxR)
                {
                    j++;
                    if (j == maxR)
                    {
                        right = false;
                        bottom = true;
                        maxR--;
                    }
                }
                else if(bottom && i < maxB)
                {
                    i++;
                    if (i == maxB)
                    {
                        bottom = false;
                        left = true;
                        maxB--;
                    }
                }
                else if(left && j > minL)
                {
                    j--;
                    if (j == minL) {
                        left = false;
                        top = true;
                        minL++;
                    }
                }
                else if(top && i > minT)
                {
                    i--;
                    if (i == minT)
                    {
                        top = false;
                        right = true;
                        minT++;
                    }
                }
            }


            return res;
        } 
    }
}
