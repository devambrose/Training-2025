using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world");

            

            String FirstName = ""; //Pascals Case

            String lastName = "James002___9393*772"; // camel Case

            String _fullName = ""; //underScore 

            // String _IDNumber = "";

            //String a = "ab";

            /**
             * this part is performing summations
             * 
             * modulus modulo
             * 7/2 3.5 
             * 
             * 2 | 7 
             *     6
             *     1
             */

            int a = 2;

            int b = 7;

            int sum = b % a;


            Console.WriteLine("The sum is {a} " + sum);

            Console.WriteLine($" The modulus of {a} % {b} =  {sum}");

            System.Console.ReadLine();
        }
    }
}
