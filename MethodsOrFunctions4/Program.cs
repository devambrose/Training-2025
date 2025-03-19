using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOrFunctions4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int , double , string , char

            // living -> // 365 -> eat , breath , watch , learn

            Console.WriteLine(GetWelcomeMessage());

            int sum = CalculateSum();

            Console.WriteLine(sum);

            Console.ReadLine();


            // Naming Convections 

            // Parameters 

            // return types 

            // Object Oriented Programming OOP
           
        }

        static int CalculateSum()
        {
            return 2;
        } 

        static string GetWelcomeMessage()
        {

            return "Welcome to The methods introduction";
        }

    }
}
