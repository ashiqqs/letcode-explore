using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.InterviewPreparationKit
{
    public class TwoDArray
    {
        static int hourglassSum(int[][] arr)
        {
            int maxSum =-63,row=0,col=1, tempSum=0;
            int count = 0;
            while(row<4)
            {
                while (col < 5)
                {
                    tempSum = arr[row][col - 1] + arr[row][col] + arr[row][col + 1]
                    + arr[row + 1][col]
                    + arr[row + 2][col - 1] + arr[row + 2][col] + arr[row + 2][col + 1];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                    col++;
                    count++;
                }
                col = 1;
                row++;
            }
            return maxSum;
        }
        public static void Execute()
        {
            Helper helper = new Helper();
            int[][] arr = new int[6][];
            for(int i=0; i<6; i++)
            {
                arr[i] = new int[6];
                arr[i]=helper.GetRandomNumbers(6, 0, 2);
            }

            for (int i = 0; i < 6; i++)
            {
                helper.PrintArray<int> (arr[i]);
            }
            Console.WriteLine("Maximum Summation is: " + hourglassSum(arr));
        }
    }
}
