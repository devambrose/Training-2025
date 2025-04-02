using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{

    //Virtual , Override ,sealed , abstract , interface


    internal class Program
    {
        static void Main(string[] args)
        {

            Audi audi = new Audi();

            audi.SetName("A4");

            string carName = audi.GetName();

            Console.WriteLine(carName);

            Console.WriteLine(audi.ToString());

            AudiSport audiSport = new AudiSport();

            audiSport.SetName("Audi Motorsport 1");

            Console.ReadLine();

        }
    }

    class GermanCar
    {
        string name {  get; set; }

        public  void SetName(string name)
        {
            this.name = name;
        }

        public virtual string GetName()
        {
            return name;
        }

    }

    class Audi : GermanCar
    {
        public sealed override string GetName()
        {   // final , name = A4

            //A4 _. Audi A4
            return "Audi "+base.GetName();
        }

        public override string ToString()
        {
            return base.GetName();
        }

    }

    class AudiSport : Audi
    {

    }


    class Car
    {
        public int speed { get; set; }

        private string Name { get; set; }

        public Car()
        {
            this.Name = "Mazda";

        }

        public Car(string name)
        {
            this.Name = name;
        }

        public Car(int speed, string name)
        {
            this.speed = speed;
            Name = name;
        }

        public void Drive()
        {
            speed++;
        }

        public void Drive(int speed) {
          this.speed = speed;
        }

        public void Drive(string SpeedString)
        {
            this.speed= int.Parse(SpeedString);
        }
    }
}
