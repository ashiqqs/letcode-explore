using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolution.InterviewPreparationKit.DictionaryHashmaps
{
    public class RansomNote
    {
        public void CheckMagagine(string[] magazine, string[] notes)
        {
            //Array.Sort(magazine);
            //Array.Sort(notes);
            //int magLen = magazine.Length,ntLen = notes.Length;
            //int counter = 0, match = 0;

            //while(counter<magLen && match < ntLen)
            //{
            //    if (magazine[counter] == notes[match]) { match++; }
            //    counter++;
            //}
            //if (match==ntLen)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            Dictionary<string, int> magazineDict = new Dictionary<string, int>();
            Dictionary<string, int> noteDict= new Dictionary<string, int>();
            foreach(var word in magazine)
            {
                if (magazineDict.ContainsKey(word))
                {
                    magazineDict[word]++;
                }
                else
                {
                    magazineDict.Add(word, 1);
                }
            }
            foreach(var word in notes)
            {
                if(magazineDict.ContainsKey(word) && magazineDict[word] > 0)
                {
                    magazineDict[word]--;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
