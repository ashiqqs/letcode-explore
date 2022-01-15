using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class DiagonalTraverse
    {
        public static int[] FindDiagonalOrder(int[][] mat)
        {
            int m = mat.Count();
            int n = mat[0].Count();
            int[] res = new int[m * n];

            int digonal = m + n - 1;
            int r= 0, c = 0, i, counter = 0, idx=0;

            int d = 0;
            while (d < digonal)
            {
                List<int> els = new List<int>();
                if (c < n-1)
                {
                    r = 0;
                    for(i=c; i>=0 && r<m; i--)
                    {
                        els.Add(mat[r][i]);
                        r++;
                    }
                    c++;
                }
                else if (c == n - 1)
                {
                    r = counter;
                    for(i=n-1; i>=0 && r<m; i--)
                    {
                        els.Add(mat[r][i]);
                        r++;
                    }
                    counter++;
                }

                if (d % 2 == 0)
                {
                    els.Reverse();
                }
                foreach (int e in els)
                {
                    res[idx++] = e;
                }

                d++;
            }

            return res;
        }

    }
}
