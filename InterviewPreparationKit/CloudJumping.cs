using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class CloudJumping
    {
        public static int CountMinJump(int[] c)
        {
            int count = 0, len = c.Length, i = 0;
            for (i = 0; i < len-1;)
            {  
                if ((i + 2) < len && c[i + 2] == 1)
                {
                    i++;
                }
                else
                {
                    i = i + 2;
                }
                count++;
            }
            return count;
        }
    }
}
