using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode
{
    public class ReplaceElement
    {
        public static int[] ReplaceElements(int[] arr)
        {
            //input [17,18,4,3,6,1]
            //output [18,6,6,6,-1]

            int start = 0;
            int end = arr.Length-1;
            int maxIdx,i,j;

            while(start < end)
            {
                maxIdx = end;
                for(i = end; i>start; i--)
                {
                    if(arr[i]>arr[maxIdx])
                        maxIdx = i;
                }
                for(j=start; j<maxIdx; j++)
                {
                    arr[j] = arr[maxIdx];
                    start++;
                }
            }

            arr[arr.Length - 1] = -1;
            return arr;
        }
    }
}
