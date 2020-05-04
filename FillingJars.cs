using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class FillingJars
    {
        static long solve(int n, int[][] operations)
        { long sum = 0;
            for(long i=0; i<operations.Length; i++)
            {
                long a = operations[i][0];
                long b = operations[i][1];
                long k = operations[i][2];
                sum += (b - a + 1) * k;
            }

            long res = sum / n;
            return res;
        }

        public static void Execute()
        {
            TextWriter textWriter = new StreamWriter(Environment.CurrentDirectory + "\\output.txt", false);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] operations = new int[m][];

            for (int operationsRowItr = 0; operationsRowItr < m; operationsRowItr++)
            {
                operations[operationsRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), operationsTemp => Convert.ToInt32(operationsTemp));
            }

            long result = solve(n, operations);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
