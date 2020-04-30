using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class ReverseGame
    {
        public static void Execute()
        {
            //n=5
            //0 1 2 3 4
            //4 3 2 1 0
            //4 0 1 2 3
            //4 0 3 2 1
            //4 0 3 1 2
            //4 0 3 1 2
            
            //k = 2 n = 5 r = 4
            //k = 3 n = 5 r = 2
            //k = 1 n = 5 r = 3

            string[] nk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            int i = 0, j = n - 1, m = 0, r = 0;
            while (m != n)
            {
                if (j != k)
                {
                    j--;
                    r++;
                }
                else
                {
                    break;
                }
                if (i != k)
                {
                    i++;
                    r++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(r);
        }
    }
}
