using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.InterviewPreparationKit
{
    public class LeftRotation
    {
        static int[] rotLeft(int[] a, int d)
        {
            int length = a.Length, temp = d, index = 0;
            int[] rotatedArr = new int[length];
            while (temp>0)
            {
                rotatedArr[length - temp--] = a[index++];
            }
            while (index < length)
            {
                rotatedArr[index - d] = a[index++];
            }
            return rotatedArr;
        }

        public static void Execute()
        {
            Helper helper = new Helper();

            int[] arr = { 1, 2, 3, 4, 5 };
            helper.PrintArray<int>(arr);
            var rotate = rotLeft(arr, 4);
            helper.PrintArray<int>(rotate);
        }
    }

}
