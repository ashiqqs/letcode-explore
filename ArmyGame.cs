using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class ArmyGame
    {
        public static void Execute()
        {
            string[] rc = Console.ReadLine().Split(' ');
            int.TryParse(rc[0], out int row);
            int.TryParse(rc[1], out int col);
            int n = 0;
            while (row > 0)
            {
                row = row - 2;
                int tempCols = col;
                while (tempCols > 0)
                {
                    tempCols = tempCols - 2;
                    n++;
                }
            }
            Console.WriteLine(n);
            //Console.WriteLine((row + row % 2) * (col + col % 2) / 4); //another way
        }
    }
}
