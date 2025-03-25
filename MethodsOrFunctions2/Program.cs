using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOrFunctions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             *  <access-modifier>  <return-type> MethodName(<Parameters>)
             * 
             *  access-modifier 
             *  public , private , protected
             *  
             *  
             *  data-types int, float, decimals ,string and char
             *  
             *  sum_of_two_numbers
             *  
             *  SumOfTwoNumbers(); _ Camel Case
             *  sumOfTwoNumbers(); _ Pascals Case
             *  
             *  Parameters 
             * 
             *  24 * 5
             *  
             *   5 * 4 * 3 * 2 * 1
             *   120
             *   
             */

            Console.WriteLine("Welcome to our factorial app");

            while (true)
            {
                InteractWithUser();
            }



        }

        static void InteractWithUser()
        {
            Console.WriteLine("Please type in a number");

            string factString = Console.ReadLine();


            try
            {
                int n = int.Parse(factString);

                int factorial = CalculateFactorial(n);

                Console.WriteLine($"The factorial of {n} is {factorial} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please use a valid number");
            }
        }

        // Calculates the Factorial of a number 
        static int CalculateFactorial(int p)
        {

            /**
             * 3 
             * 4 * 3* 2 *1
             * 3 * 2 * 1 =
             * 1 * 2* 3* 4 * 5 5 < 6
             */
            if (p == 0)
                return 1;

            int result = 1;

            for(int i = 1;i<p+1; i++)
            {
                result *= i;
            }

            return result;
        }

    }
}
