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
            string[] input = Console.ReadLine().Split();
            var exit = new Dictionary<char, int>();
            foreach (string i in input)
            {
                foreach (char y in i)
                {
                    if (exit.ContainsKey(y))
                    {
                        exit[y] += 1;
                    }
                    else
                    {
                        exit.Add(y, 1);
                    }
                }
            }

            foreach (var k in exit)
            {
                Console.WriteLine(k.Key + " -> " + k.Value);
            }
        }
    }
}