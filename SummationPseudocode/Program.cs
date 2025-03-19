using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationPseudocode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // summation of two numbers 

            // interactive & static

            /*
              number x = 5
              
              number y= 5
              
              value sum = x +y
              
              output sum 
             */

            int x = 5;

            int y = 10;

            int sum = x + y;

            Console.WriteLine(sum);

            //  Dynamic Section

            /**
             * output message input first number
             * read first number
             * output message for the second number
             * read second number
             * 
             * converted the inputs from string to int 
             * calculate the sum 
             * 
             * output the sum
             * 
             * 
             */

            // numerals & text

            // text _> char string

            char a= 'a';

            string text = "welcome to summation application";


            // if 



            while (true)
            {

                Console.WriteLine(text + " \n Type in the first number");

                string number1 = Console.ReadLine();

                Console.WriteLine("Type in the second number");

                string number2 = Console.ReadLine();


                try
                {
                    x = Int32.Parse(number1);

                    y = Int32.Parse(number2);

                    sum = x + y;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(" I failed but i shall work ");
                }

                Console.WriteLine($"The sum is {sum}");

            }

           

            Console.ReadLine();
        }
    }
}
