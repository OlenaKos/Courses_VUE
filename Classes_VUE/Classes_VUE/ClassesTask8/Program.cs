using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask8
{
    class Program
    {
        static void Main(string[] args)
        {

            Invoice inv = new Invoice(1, "Pavlo", "ODBC");
            inv.Show (5, 45, 0.3);
            inv.Show (2, 9.34, 0.2);

            Console.ReadLine();


        }
    }
}
