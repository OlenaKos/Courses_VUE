using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ClassesTask7
{
    enum Positions { Junior, Staff, Senior };
    class Employee
    {
        public string FName { set; get; }
        public string LName { set; get; }
        public DateTime ExperienceStart { set; get; }
        public Positions Position { set; get; }

        public Employee(string fname, string lname)
        {
            FName = fname;
            LName = lname;
        }
        public double GetExperience()
        {
            DateTime Now = DateTime.Now;
            double Exp = (Now - ExperienceStart).TotalDays/365;
            return Exp;
        }

        public double GetTax()
        {
            double res = 0;

            if (GetExperience() < 3)
                res = 0.2;
            else
                res = 0.3;
            return res;
        }

        public double GetSalary()
        {
            double salary = 500;
            double PositionMultiplier = 1;
            switch (Position)
            {
                case Positions.Staff:
                    {
                        PositionMultiplier = 3;
                        break;
                    }
                case Positions.Senior:
                    {
                        PositionMultiplier = 5;
                        break;
                    }
                default:
                    break;
            }

            salary = PositionMultiplier * salary + salary * GetExperience() / 5;

            return salary;
        }

        public void Show()
        {
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name + " " + property.GetValue(this));
                
            }
            Console.WriteLine("Experience = {0}, Tax = {1}, Salary = {2}", GetExperience(), GetTax(), GetSalary());
        }


    }
}
