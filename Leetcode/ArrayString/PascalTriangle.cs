using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class PascalTriangle
    {
       //      1
       //     1 1
       //    1 2 1
       //   1 3 3 1
       //  1 4 6 4 1
       // 1 5 10 10 5 1
      // 1 6 15 20 15 6 1
        
        public static IList<int> GetRow(int rowIndex)
        {
            double row = rowIndex;
            IList<int> result = new List<int>();
            result.Add(1);

            for(double i=1; i<=rowIndex; ++i)
            { 
                double v = (rowIndex - i + 1) / i * result[(int)i - 1];
                result.Add((int)v);
            }

            return result;
        }
    }
}
