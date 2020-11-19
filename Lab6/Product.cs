using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Product
    {
        public string name;
        public double amount;
        public double price_buy;
        public double price_sell;

        public Product(string name, double amount, double price_buy)
        {
            this.name = name;
            this.amount = amount;
            this.price_buy = price_buy;
            price_sell = price_buy * 1.2;
        }

        public Product(string name, double amount, double price_buy, double price_sell) : this(name, amount, price_buy)
        {
            this.price_sell = price_sell;
        }
    }
}
