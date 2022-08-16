using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = new Dictionary<string, double>();
            var quantity = new Dictionary<string, double>();
            string command;
            while((command = Console.ReadLine()) != "buy")
            {
                string[] commandSplitter = command.Split();
                string key = commandSplitter[0];
                double pPrice = double.Parse(commandSplitter[1]);
                double pQuantity = double.Parse(commandSplitter[2]);

                if (price.ContainsKey(key))
                {
                    price[key] = pPrice;
                    quantity[key] += pQuantity;
                }
                else
                {
                    price.Add(key, pPrice);
                    quantity.Add(key, pQuantity);
                }
            }

            foreach(var a in price)
            {
                foreach (var b in quantity)
                {
                    if(a.Key == b.Key)
                    {
                        Console.WriteLine(a.Key + " -> " + "{0:f2}", a.Value * b.Value);
                    }
                }
            }
        }
    }
}