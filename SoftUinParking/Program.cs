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
            int n = int.Parse(Console.ReadLine());
            var registered = new Dictionary<string, string>();
            for(int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "register")
                {
                    if (registered.ContainsKey(command[1]))
                    {
                        Console.WriteLine("ERROR: already registered with plate number {0}", command[2]);
                    }
                    else
                    {
                        Console.WriteLine("{0} registered {1} successfully", command[1], command[2]);
                        registered.Add(command[1], command[2]);
                    }
                }
                if (command[0] == "unregister")
                {
                    if (registered.ContainsKey(command[1]))
                    {
                        registered.Remove(command[1]);
                        Console.WriteLine("{0} unregistered successfully", command[1]);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: user {0} not found", command[1]);
                    }
                }
            }

            foreach(var a in registered)
            {
                Console.WriteLine(a.Key + " => " + a.Value);
            }
        }
    }
}
