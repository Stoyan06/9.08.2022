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
            var list = new Dictionary<string, List<string>>();
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] commandSplitter = input.Split(" -> ");
                if (list.ContainsKey(commandSplitter[0]))
                {
                    if (!list[commandSplitter[0]].Contains(commandSplitter[1]))
                    list[commandSplitter[0]].Add(commandSplitter[1]);
                }
                else
                {
                    list[commandSplitter[0]] = new List<string>();
                    if (!list[commandSplitter[0]].Contains(commandSplitter[1]))
                    {
                        list[commandSplitter[0]].Add(commandSplitter[1]);
                    }
                }
            }

            foreach(var a in list)
            {
                Console.WriteLine(a.Key);
                foreach(var b in list[a.Key])
                {
                    Console.WriteLine("-- " + b);
                }
            }
        }
    }
}
