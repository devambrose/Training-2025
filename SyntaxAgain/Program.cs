using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Syntax and Semantics

namespace SyntaxAgain
{

    internal class Program
    {
        static void Main(string[] args)
        {

            // text and numerals 

            string welcomeMessage = "Hello World";

            char a = 'a';

            var welcomeMsg = "Hello world";

            var b = 'b';

            Console.WriteLine($" the message : {welcomeMessage}");

            //numerals : 

            int x = 6;
            int y = 4;

            // + * / -  %  6/ 4 => 2

            int sum = x + y;

            Console.WriteLine($"the sum : {sum}");

            Console.WriteLine($"the subtract : {x-y}");

            Console.WriteLine($"the division : {x/y}");

            Console.WriteLine($"The multiplication : {x * y}");

            Console.WriteLine($"The modulus : {x % y}");

            Console.ReadLine();

        }
    }
}
