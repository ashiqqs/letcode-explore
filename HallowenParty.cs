using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class HallowenParty
    {
        public static void Execute()
        {
            int k = int.Parse(Console.ReadLine());
            int r1 = k / 2;
            int r2 = k % 2;
            long res = (r1 + r2) * r1;
            Console.WriteLine(res);
        }
    }
}
