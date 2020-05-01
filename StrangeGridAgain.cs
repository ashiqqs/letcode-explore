using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class StrangeGridAgain
    {
        public static void Execute()
        {
            long[] rc = Array.ConvertAll(Console.ReadLine().Split(), n => Int64.Parse(n));
            long row = rc[0];
            long col = rc[1];
            // for(int i =0; i<row-1; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         selectedCellVal += 1;
            //     }
            //     else
            //     {
            //         selectedCellVal += 9;
            //     }
            // }
            long selectedRowFirsVal = (row % 2 == 0)?(((row / 2)) * 10)-9 : (long)Math.Ceiling((double)(row / 2)) * 10;
            selectedRowFirsVal += 2 * (col - 1);
            Console.WriteLine(selectedRowFirsVal);
        }
    }
}
