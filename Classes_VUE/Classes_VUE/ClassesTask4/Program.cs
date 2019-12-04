using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask4
{
    class Program
    {
        static void Main(string[] args)
        {

            Point first = new Point(0, 0, "point1");
            Point second = new Point(3, 4, "point2");
            Point third = new Point(7, 7, "point3");
            Point fourth = new Point(-3, 4, "point4");
            Point fifth = new Point(-4, 7, "point5");

            Figure triangle = new Figure(first, second, third);
            triangle.Show();

            Figure quadrangle = new Figure(first, second, third, fourth);
            quadrangle.Show();

            Figure pentagon = new Figure(first, second, third, fourth, fifth);
            pentagon.Show();

            Console.ReadLine();


        }
    }
}
