using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class SearchString
    {
        public static int StrStr(string haystack, string needle)
        {
            if (needle == "")
            {
                return 0;
            }
            if (needle.Length > haystack.Length)
            {
                return -1;
            }
            int i = 0;

            while(i<haystack.Length && (haystack.Length-i)>=needle.Length)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}
