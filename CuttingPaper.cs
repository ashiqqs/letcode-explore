using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class CuttingPaper
    {
        static long solve(int n, int m)
        {
            long res = (long)m * (long)n - 1;
            return res;
        }

        public static void Execute()
        {
            TextWriter textWriter = new StreamWriter(Environment.CurrentDirectory + "\\output.txt", false);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            long result = solve(n, m);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();

            Console.WriteLine(File.ReadAllText(Environment.CurrentDirectory + "\\output.txt"));
        }
    }
}
