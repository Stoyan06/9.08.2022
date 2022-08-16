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
            int i = int.Parse(Console.ReadLine());
            var list = new Dictionary<string, double>();
            for(int x = 0; x < i; x++)
            {
                string input1 = Console.ReadLine();
                double input2 = double.Parse(Console.ReadLine());
                if (list.ContainsKey(input1))
                {
                    list[input1] = (list[input1] + input2) / 2;
                }
                else
                {
                    list.Add(input1, input2);
                }
            }

            foreach(var a in list)
            {
                if (a.Value >= 4.50)
                {
                    Console.WriteLine(a.Key + " -> " + "{0:f2}", a.Value);
                }
            }
        }
    }
}
