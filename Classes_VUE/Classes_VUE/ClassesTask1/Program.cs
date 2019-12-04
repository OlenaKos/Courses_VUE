using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Address adress = new Address();
            adress.Apartment = "15";
            adress.City = "Istanbul";
            adress.Country = "Turkey";
            adress.House = "6A";
            adress.Index = "4646";
            adress.Street = "Fleet st";

            adress.PrintAddress();
        }
    }
}
