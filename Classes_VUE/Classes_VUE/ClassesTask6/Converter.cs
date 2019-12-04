using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ClassesTask6
{
    class Converter
    {
        public double USD { set; get; }
        public double EURO { get; set; }
        public double RUB { get; set; }
        public Converter( double usd, double euro, double rub)
        {
            USD = usd;
            EURO = euro;
            RUB = rub;
        }
        public double ConvertToUAH(double amount, string currencyName)
        {
            PropertyInfo property = this.GetType().GetProperty(currencyName);
            double res = amount * Convert.ToDouble(property.GetValue(this));
            return res;
        }

        public double ConvertFromUAH(double amount, string currencyName)
        {
            PropertyInfo property = this.GetType().GetProperty(currencyName);
            double res = amount / Convert.ToDouble(property.GetValue(this));
            return res;
        }
    }
}
