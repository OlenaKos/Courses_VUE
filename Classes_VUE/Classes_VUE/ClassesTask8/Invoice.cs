using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask8
{
    class Invoice
    {
        readonly int account;
        public int Account { get { return account; } }
        readonly string customer;
        public string Customer { get { return customer; } }
        readonly string provider;
        public string Provider { get { return provider; } }
        string article;
        int quantity;

        public Invoice(int acc, string custmr, string prov)
        {
            account = acc;
            customer = custmr;
            provider = prov;
        }

        public double CalculateAmount(int quantity, double price)
        {
            double res = 0;
            res = quantity * price;

            return res;
            
        }

        public double CalculateAmount(int quantity, double price, double tax = 0.2)
        {
            double res = 0;
            res = CalculateAmount(quantity, price) * (1 + tax);

            return res;
        }

        public void Show(int quantity, double price, double tax = 0.2)
        {
            Console.WriteLine("Amount without NDS = {0}", CalculateAmount(quantity, price));
            Console.WriteLine("Amount with NDS = {0}", CalculateAmount(quantity, price, tax));
        }
    }
}
