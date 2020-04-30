using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    class Program
    {

        static void Main(string[] args)
        {
            //FindThePoint.Execute();
            //ArmyGame.Execute();
            //MaxPrimeFactor.Execute();
            //ConnectingTowns.Execute();
            //CuttingPaper.Execute();
            //BestDivisor.Execute();
            //Sorting.Bubble();
            ReverseGame.Execute();

            Console.ReadKey();

        }
        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            else if (b == 0)
                return a;
            else
                return gcd(b%a,a);
        }
    }
}
