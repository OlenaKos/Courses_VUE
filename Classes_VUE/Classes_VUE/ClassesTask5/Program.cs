using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask5
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User("JamesB", "James", "Bond", 8);
            user.Show();

            Console.ReadLine();

        }
    }
}
