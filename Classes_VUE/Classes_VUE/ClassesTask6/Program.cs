using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(23.94, 26.54, 0.37);

            Console.WriteLine("100 euro to hryvna = {0}", converter.ConvertToUAH(100, "EURO"));
            Console.WriteLine("123 rub to hryvna = {0}", converter.ConvertToUAH(123, "RUB"));
            Console.WriteLine("190 usd to hryvna = {0}", converter.ConvertToUAH(190, "USD"));
            
            Console.WriteLine("100 hrn to euro = {0}", converter.ConvertFromUAH(100, "EURO"));
            Console.WriteLine("123 hrn to rub = {0}", converter.ConvertFromUAH(123, "RUB"));
            Console.WriteLine("190 hrn to usd = {0}", converter.ConvertFromUAH(190, "USD"));

            Console.ReadLine();
        }
    }
}
