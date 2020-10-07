using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.InterviewPreparationKit
{
    public class NewYearChaos
    {
        public static void minimumBribes(int[] q)
        {
            int len = q.Length;
            int minBribes = 0, min = len, max=len;
            for (int i = len-1; i >=0; i--)
            {
                if ((q[i] - (i + 1)) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                if(q[i]>min)
                {
                    minBribes++;
                }
                if (q[i] > max)
                {
                    minBribes++;
                }
                if(q[i]<min || q[i] < max)
                {
                    if (q[i]>min && q[i]<max)
                    {
                        max = q[i];
                    }
                    else
                    {
                        max = min;
                        min = q[i];
                    }
                }
                
            }
            Console.WriteLine(minBribes);
        }
    }
}
