
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /**
             *  for , while , do-while, foreach
             * 1 -> 365 
             * 
             * 
             */

            int count = 100;
           
            for (int i=0; i< count; i++)
            {
                Console.WriteLine($" i = {i} i< {count}: {i<count} ");
            }

            // do while   //foreach => data , lists

            Console.ReadLine();

            

            


        }

        static void ValidateAgeApplication()
        {
            bool exec = true;

            while (exec)
            {
                Console.WriteLine("Please input your age");

                string ageText = Console.ReadLine();


                int age = Int32.Parse(ageText);

                if (age > 30)
                {
                    exec = false;
                    Console.WriteLine(" Thank you for growing old \n \n");
                }
                else
                {
                    Console.WriteLine("Keep pushing \n \n");

                }


            }

            Console.WriteLine("Thank you for visiting this app");


            Console.ReadLine();
        }
    }
}
