using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }

    // Contract _> Interface ICar

    // abstract , static , generics 

    // api's 

    interface ICar
    {
        void Driving();

        void Idling();
    }

    class Toyota : ICar
    {
        public void Driving() { 
        
        }

        public void Idling() { 
        
        }
    }

    interface ITransaction
    {
        void Create();

         void Delete();

        void Edit();

        string Read();
    }

    class MpesaTransaction : ITransaction {

        public void Delete() {

        }

        public void Edit() { 
        }
        public string Read() 
            {
            return "";

            }
        public void Create()
        {

        }

    }


}
