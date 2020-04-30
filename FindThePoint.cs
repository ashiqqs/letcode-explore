using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class FindThePoint
    {
        static int[] findPoint(int px, int py, int qx, int qy)
        {
            /*
             * Write your code here.
             */
             //let mid point is qx, qy; start point PxPy and end point RxRy
             //So, Mid point Qx = (Px+Qx)/2; and Qy = (Py+Qy)/2;
             //from this equation we can get Rx & Ry
            int r1 = 2 * qx - px;
            int r2 = 2 * qy - py;
            return new[] { r1, r2 };
        }

        public static void Execute()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            for (int nItr = 0; nItr < n; nItr++)
            {
                string[] pxPyQxQy = Console.ReadLine().Split(' ');

                int px = Convert.ToInt32(pxPyQxQy[0]);

                int py = Convert.ToInt32(pxPyQxQy[1]);

                int qx = Convert.ToInt32(pxPyQxQy[2]);

                int qy = Convert.ToInt32(pxPyQxQy[3]);

                int[] result = findPoint(px, py, qx, qy);

                textWriter.WriteLine(string.Join(" ", result));
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

