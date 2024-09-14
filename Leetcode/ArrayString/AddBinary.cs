using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class AddBinary
    {
        public static string Add(string a, string b)
        {
            int lengthA = a.Length-1;
            int lengthB = b.Length-1;
            int parity = 0;
            int s = 0;
            string result = string.Empty;
            while(lengthA >= 0 || lengthB >= 0 || parity==1)
            {
                s += lengthA >= 0 ? a[lengthA] - '0' : 0;
                s += lengthB >= 0 ? b[lengthB] - '0' : 0;
                s += parity;
                result = (s > 1 ? s == 2 ? "0" : "1" : s.ToString()) + result;
                parity = s > 1 ? 1 : 0;
                s = 0;
                lengthA--;
                lengthB--;
            }
            return result;
        }
    }
}
