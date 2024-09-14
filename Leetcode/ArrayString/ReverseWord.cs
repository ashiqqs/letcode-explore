using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.Leetcode.ArrayString
{
    public class ReverseWord
    {

        public static string Reverse1(string s)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            bool searching = false;

            for(int i = s.Length-1; i>=0; i--)
            {
                if(s[i] != ' ')
                {
                    if (!searching)
                    {
                        count = 1;
                        searching = true;
                    }
                    else
                    {
                        count++;
                    }
                }
                else
                {
                    if (searching)
                    {
                        sb.Append(s.Substring(i+1, count)+" ");
                    }
                    searching = false;

                }
            }
            if (searching)
            {
                sb.Append(s.Substring(0, count));
            }
            return sb.ToString().Trim();
        }



        public static string reverse(string s, int start, int end)
        {
            return  String.Join(" ", s.Split(' ').Select(x => rev(x)));
        }

        private static string rev(string s)
        {
            var charArr = s.ToCharArray();
            char c;
            for(int i=0, j=s.Length-1; i<j; i++, j--)
            {
                c = charArr[i];
                charArr[i] = charArr[j];
                charArr[j] = c;
            }
            return new string(charArr);
        }
    }
}
