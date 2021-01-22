using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word.");
            string word = Console.ReadLine();
            Console.WriteLine("There are " + CountVowels(word) + " vowels in " + word);
        }
        static int CountVowels(string word)
        {
            int vowelcount = 0;
            string vowels = "aeiou";
            for(int i = 0; i < word.Length; i++)
            {
                for(int j = 0; j < vowels.Length; j++)
                {
                    if(word[i] == vowels[j])
                    {
                        vowelcount += 1;
                        break;
                    }
                }
            }
            return vowelcount;
        }

    }
}
