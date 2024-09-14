using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class Reverse
    {
        public static void ReverseString(char[] s)
        {
            int i = 0, j=s.Length-1;
            char c;
            while(i < j) { 
                c = s[i];
                s[i] = s[j];
                s[j] = c;
                i++; j--;
            }
             Console.WriteLine(s);
        }
    }
}
