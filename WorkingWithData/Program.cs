using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ambrose like cake";

            List<string> bananaList = new List<string>();

            bananaList.Add("Ambrose Like Cake");
            bananaList.Add("Ambrose Codes");
            bananaList.Add("Ambrose");

            foreach (var banana in bananaList)
            {
                Console.WriteLine(banana);
            }

            // HashMaps Dictionary  // List //LinQ  

            Console.ReadLine();
        }
    }

}

