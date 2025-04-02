using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MazdaCar mazdaCar = new MazdaCar("Mazda Cx5");
           
            MazdaCar mazdaAtenza = new MazdaCar("Mazda Atenza");

            Car escudo = new Car();

            Volkswagen tiguan = new Volkswagen();

            tiguan.Name = "Tiguan";

            Volkswagen passat = new Volkswagen("Passat");





            Console.WriteLine(mazdaCar.GetParentInlineType());

            Console.WriteLine(escudo.GetInlineType());
            Console.WriteLine(tiguan.GetInlineType());
            Console.WriteLine(passat.GetInlineType());
         

            Console.ReadLine();

        }
    }

    //Inheritance 
    class Car
    {
        public string Name { get; set; }

        protected string _type {  get; set; }

        public void SetInlineType(string Type)
        {
            this._type = Type;
        }

        public string GetInlineType()
        {
            return _type;
        }

        private string YearOfManufacture {  get; set; }

        
       
    }

    class Volkswagen : Car
    {
        public Volkswagen()
        {
            this._type = "VW";

        }

        public Volkswagen(string name)
        {
            this._type = "VW:inline";

            this.Name = name;
        }

    }

    class MazdaCar : Car { 

        public MazdaCar(string name) {

            this.Name = name;

            this._type = "Mazda";

        }

        public string GetParentInlineType()
        {
            return this.GetInlineType();
        }
    
    }

}
