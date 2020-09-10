using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    public class SpecialMultiple
    {
        public static void Execute()
        {
            int specialMultiple = 9;
            int i = 1, n = 500;
            while (specialMultiple % n != 0)
            {
                i++;
                specialMultiple = GetDecToBin(i)*9;
            }
            Console.WriteLine(specialMultiple);

             i = 1;
            Console.WriteLine(++i+ ++i);
            Console.WriteLine(i+++i++);
            Console.WriteLine(i+++i++);
        }
        private static int GetDecToBin(int decimalNum)
        {
            string binStr = "";
            while (decimalNum != 0)
            {
                binStr += (decimalNum % 2);
                decimalNum /= 2;
            }
            int.TryParse(String.Join("",binStr.Reverse()), out int binNUm);
            return binNUm;
        }
    }
}
