using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.InterviewPreparationKit
{
    public class RepeatedString
    {
        static long CountRepeated(string s, long n)
        {
            long count=0;
            int strLen = 0;
            int numberOf_a = 0;
            foreach(char c in s)
            {
                if (c == 'a')
                {
                    numberOf_a++;
                }
                strLen++;
            }
            count = (n / strLen) * numberOf_a;
            long lastSubStrLen = n % strLen;
            for(int i=0; i<lastSubStrLen; i++)
            {
                if (s[i] == 'a')
                {
                    count++;
                }
            }

            return count;
        }
        public static void Execute()
        {
            string s = "a";
            long count = CountRepeated(s, 1000000000000);
            Console.WriteLine(count);
        }
    }
}
