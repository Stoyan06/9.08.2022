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
            var dudesData = new Dictionary<string, List<string>>();
            string input;
            while((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] commandSplitter = input.Split(" <:> ");
                string name = commandSplitter[0];
                string color = commandSplitter[1];
                string physics = commandSplitter[2];
                dudesData[name] = new List<string>();
                dudesData[name].Add(color);
                dudesData[name].Add(physics);
            }
        }
    }
}
