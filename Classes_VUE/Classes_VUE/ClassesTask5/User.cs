using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ClassesTask5
{
    class User
    {
        public string Login { get; set; }
        public string Fname { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        readonly DateTime creationDate;
        public DateTime CreationDate { get { return creationDate; } }
        public User()
        {
         
        }
        public User(string login, string fname, string lname, int age)
        {
            Login = login;
            Fname = fname;
            LName = lname;
            Age = age;
            creationDate = DateTime.Now;
        }
        public void Show()
        {
            Type t = typeof(User);
            PropertyInfo[] properties = t.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name + " " + property.GetValue(this));
            }
        }
    }
}
