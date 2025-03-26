using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1
{
    internal class Program
    {
        // Abstraction

        // Inheritance

        // public , private and protected 
        // Polymorphism

        // Encapsulation

        /// access-mofidier return-type{void|int|string|List }  nameMethod CamelCase | Pascals 


        static void Main(string[] args)
        {

            Console.WriteLine("Wlcome to the Human Domain");

            //Grading for Students -> Name , Score  => 120000
            while (true)
            {
                HumanBeing humanBeing = GetFromUser();

                Console.WriteLine($"{humanBeing.Name} color : ${humanBeing.GetColor()}");
            }
           

            Console.ReadLine();

        }

        static HumanBeing GetFromUser()
        {
            HumanBeing inlineHumanBeing = new HumanBeing();

            Console.WriteLine(" What is your name?");

            inlineHumanBeing.Name = Console.ReadLine();

            Console.WriteLine(" What is the collor of your skin ?");

            inlineHumanBeing.SetColor(Console.ReadLine());

            Console.WriteLine("Can you walk?");

            return inlineHumanBeing;
        }
    }

        // Class HumanBeing {name,height,color,legs,hands,mouth,fingers  walk(),talk(),eat(),breath()}

    class HumanBeing
    {
        public string Name { get; set; }

        private String Color { get;set; }
      
        public float Heigt { get; set; }
      
        public int Legs { get; set; }

        public void SetColor(string color)
        {
            Color = color;
        }

        public string GetColor()
        {
            return Color;
        }
    }
    


        // Fruit {type,status{ripe,unripe},color,isConnected {true|false} grow(),} 
}
