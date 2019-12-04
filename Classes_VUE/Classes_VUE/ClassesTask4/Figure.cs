using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask4
{
    class Figure
    {
        List<Point> pointSet { get; set; }
        public Figure(Point first, Point second, Point third)
        {
            pointSet = new List<Point> { first, second, third };
        }
        public Figure(Point first, Point second, Point third, Point fourth)
        {
            pointSet = new List<Point> { first, second, third, fourth };
        }
        public Figure(Point first, Point second, Point third, Point fourth, Point fifth)
        {
            pointSet = new List<Point> { first, second, third, fourth, fifth };
        }

        public double LengthSide(Point A, Point B)
        {
            double res = 0;
            res = Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
            return res;
        }
        public double PerimeterCalculator()
        {
            double res = 0;
            double length = 0;
            for (int i = 0; i < pointSet.Count - 1; i++)
            {
                length = LengthSide(pointSet[i], pointSet[i + 1]);
                Console.WriteLine("{0} length of side = {1}", i, length);
                res += length;//LengthSide(pointSet[i], pointSet[i + 1]);
            }
            length =  LengthSide(pointSet[pointSet.Count-1], pointSet[0]);
            Console.WriteLine("Last length  = {0}", length);
            res += length;
            return res;
        }

        public void Show()
        {
            Console.WriteLine("You have figure with {0} sides", pointSet.Count);
            Console.WriteLine("Your perimeter equal = {0}", PerimeterCalculator());
        }
    }
}
