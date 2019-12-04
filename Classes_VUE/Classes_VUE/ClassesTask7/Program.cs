using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask7
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee("James", "Bond");
            employee.ExperienceStart = new DateTime(2015, 7, 20, 18, 30, 25);//20.07.2015 18:30:00
            employee.Position = Positions.Junior;

            employee.Show();
            Console.ReadLine();


        }
    }
}
