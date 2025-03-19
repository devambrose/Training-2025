using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // create a program that calculates the average grade for a list of students

            List<double> list = new List<double>();

            while (true) {
               
                Console.WriteLine("Type in the grade or type exit");

                string value= Console.ReadLine();

                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please Input a valid grade");

                    continue;
                }

                if (value.ToString().ToLower() == "exit")
                {
                    Console.WriteLine("Thank you");

                    break;
                }

                try
                {
                    double grade = double.Parse(value);

                    list.Add(grade);
                }
                catch (Exception ex) {
                    Console.WriteLine("Please Input a valid grade - numeric 1,3,4");
                }
            }


            double total = 0;

            foreach (double grade in list) {
                total = total + grade;
            }

            double average = total / list.Count;

            Console.WriteLine("The total is " + total);
            Console.WriteLine("The items in the list are " + list.Count);
            Console.WriteLine("The average score "+average+"");

            Console.ReadLine();

        }

        static void DoubleFloatCalculation()
        {
            // int , double , float
            // 

            int x = 4;

            int y = 4;

            int z = x + y;

            // 8 

            // string -> int Int32.Parse

            //int.Parse()


            double p = 5f;

            double q = 3f;

            float r = float.Parse(p.ToString()) / float.Parse(q.ToString());
            double rd = p / q;

            Console.WriteLine($"the division Float {r}");

            Console.WriteLine($"the division double {rd}");

            Console.ReadLine();
        }
    }
}
