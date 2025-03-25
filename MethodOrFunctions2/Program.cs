using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOrFunctions2
{
    internal class Program
    {
        // Calculate te

        // Palindrome Checker  Madam -> boolean true or false
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Palindrome Checker");

            InteractWithUser();
        }

        static void InteractWithUser()
        {
            while (true)
            {
                Console.WriteLine("Type in a word");

                string text= Console.ReadLine();

                if (CheckIsPalindrome(text))
                {
                    Console.WriteLine("This is a palindrome");
                }
                else
                {
                    Console.WriteLine("This is not a Palindrome");
                }
            }
        }

        static bool CheckIsPalindrome(string text)
        {
            string word = text.ToLower();// AmbRose -> ambrose , MWANGI  mwangi
            
            // -> madam  ma d am  -> 5/ 2 -> 2

            for(int i=0; i< word.Length/2; i++)
            {
                if (word[i]  != word[word.Length - 1 - i])
                {
                    return false;
                }

            }

                       
            return true;
        }


    }
}
