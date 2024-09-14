using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class LongestPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }
            StringBuilder result = new StringBuilder("");
            int i = 0, j=0;
            bool isCommon = false;
            while (true)
            {
                if (i == strs[j].Length)
                {
                    break;
                }
                var prefix = (strs[j])[i];
                for(j=1; j<strs.Length; j++)
                {
                    if (i == strs[j].Length)
                    {
                        isCommon = false;
                        break;
                    }
                    isCommon = strs[j][i] == prefix;
                    if (!isCommon)
                    {
                        break;
                    }
                }
                if (isCommon)
                {
                    result.Append(prefix);
                    i++;
                    j = 0;
                }
                else
                {
                    break;
                }
            }
            return result.ToString();
        }
    }
}
