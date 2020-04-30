using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class ConnectingTowns
    {
        static int connectingTowns(int n, int[] routes)
        {
            int result = routes.Aggregate(1, (a, b) => (b * a) % 1234567);
            return result;
        }

        public static void Execute()
        {
            TextWriter textWriter = new StreamWriter(Environment.CurrentDirectory+"\\output.txt", false);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] routes = Array.ConvertAll(Console.ReadLine().Split(' '), routesTemp => Convert.ToInt32(routesTemp))
                ;
                int result = connectingTowns(n, routes);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
            Console.WriteLine(File.ReadAllText(Environment.CurrentDirectory + "\\output.txt"));
        }
    }
}
