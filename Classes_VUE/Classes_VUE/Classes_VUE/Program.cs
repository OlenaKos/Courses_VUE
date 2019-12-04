using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2
            double side1, side2;
            Console.WriteLine("Enter side 1");
            if (!Double.TryParse(Console.ReadLine(), out side1))
            {
                Console.WriteLine("Wrong side 1 definition");
            };
            Console.WriteLine("Enter side 2");
            if (!Double.TryParse(Console.ReadLine(), out side2))
            {
                Console.WriteLine("Wrong side 2 definition");
            };

            Rectangle rect = new Rectangle(side1, side2);
            Console.WriteLine("Rectangle area = " + rect.Area);
            Console.WriteLine("Rectangle perimeter = " + rect.Perimeter);



            Console.ReadLine();

        }
    }
}
