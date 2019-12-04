using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask4
{
    class Point
    {
        int x;
        int y;
        string name;

        public int X { get {return x;} }
        public int Y { get { return y; } }
        public string Name { get { return name; } }

        public Point()
        {

        }

        public Point(int first, int second, string enteredName)
        {
            x = first;
            y = second;
            name = enteredName;
        }


    }
}
