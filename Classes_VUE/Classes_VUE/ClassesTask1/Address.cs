using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ClassesTask1
{
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public void PrintAddress ()
        {
            Type t = typeof(Address);
            PropertyInfo[] properties = t.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name + " " + property.GetValue(this));
            }

        }

    }
}
