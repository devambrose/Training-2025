using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithData1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           // List , Dictionary 

            List<string> list = new List<string>() { "Ambrose","Mwangi","Mburu" };

            list.Add("John");

            list.Add("June");

           

           

            Dictionary<int,string>  keyValuePairs = new Dictionary<int,string>();

            keyValuePairs[1] = "james";

            keyValuePairs[3] = "Mwangi";

            keyValuePairs.Add(11, "Simpel add");

            keyValuePairs[67] = "Sample";

            foreach(int key in keyValuePairs.Keys)
            {
                Console.WriteLine(keyValuePairs[key]);
            }

            //  Console.WriteLine(s);

            Console.ReadLine();

            Dictionary<string,int> keyValuePairs1 = new Dictionary<string,int>();

            keyValuePairs1["one"] = 1;

            keyValuePairs1["two"] = 2;

            foreach (string key in keyValuePairs1.Keys) { 
              Console.WriteLine($"{key}  value {keyValuePairs1[key]}");
            }

            Dictionary<int, List<string>> dictList = new Dictionary<int, List<string>>();


            dictList[1] = new List<string>() { "Ambrose","Mwangi","Mburu" };

            dictList.Add(3, new List<string>() { "Sharon","Boni" });

        }

        static void StringArrayMethod()
        {
            string name = "Ambrose";

            Console.WriteLine($"The length  {name.Length - 1}");

            Console.WriteLine(name.Substring(2, 5));

            Console.ReadLine();
        }

        static void IntArrayMethod()
        {
            int[] numbers = { 56, 51, 41, 10, 89, 30049 };

            // 0 ,1 ,2 , 4

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"@index {i} value is {numbers[i]} ");
            }

            Console.WriteLine("While Loop");

            int y = 0;

            while (y < numbers.Length)
            {
                Console.WriteLine($"@index {y} value is {numbers[y]} ");
                y++;
            }
            Console.WriteLine("___ \n \n ForEach Loop");

            foreach (int i in numbers)
            {
                Console.WriteLine($"value {i}");
            }
        }
    }
}
