using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class DiwaliLights
    {
        public static void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            //int res = (int)((Math.Pow(2,n)-1)%100000);
            int res = 1;
            for (int i=0; i<n; i++)
            {
                res = (res*2)%100000;
            }
            Console.WriteLine(res-1);
        }
    }
}
