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
            var exit = new Dictionary<string, int>();
            string input1;
            while((input1 = Console.ReadLine()) != "stop")
            {
                int input2 = int.Parse(Console.ReadLine());
                if (exit.ContainsKey(input1))
                {
                    exit[input1] += input2;
                }
                else
                {
                    exit.Add(input1, input2);
                }
            }

            foreach(var a in exit)
            {
                Console.WriteLine(a.Key + " -> " + a.Value);
            }
        }
    }
}