using HackerrankSolution.InterviewPreparationKit;
using HackerrankSolution.InterviewPreparationKit.DictionaryHashmaps;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution
{
    class Program
    {

        static void Main(string[] args)
        {
            RansomNote ransomNote = new RansomNote();
            string[] magazines = "two times three is not four".Split(' ').Select(word => word).ToArray();
            string[] notes = "two times two is four".Split(' ').Select(word => word).ToArray();
            
            ransomNote.CheckMagagine(magazines, notes);

            Console.ReadKey();
        }
        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            else if (b == 0)
                return a;
            else
                return gcd(b%a,a);
        }
    }
}
