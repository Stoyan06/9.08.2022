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
            var names = new Dictionary<string, int>();
            var courses = new Dictionary<string, List<string>>();
            string input;
            while((input = Console.ReadLine()) != "no more time")
            {
                string[] commandSplitter = input.Split(" -> ");
                string name = commandSplitter[0];
                string course = commandSplitter[1];
                int points = int.Parse(commandSplitter[2]);
                names.Add(name, points);
                if (courses.ContainsKey(course))
                {
                    if (courses[course].Contains(name))
                    {
                        names[name] += points;//
                    }
                    else
                    {
                        courses[course].Add(name);
                        names[name] += points;
                    }
                }
                else
                {
                    courses[course] = new List<string>();
                    courses[course].Add(name);
                    names[name] += points;
                }
            }
        }
    }
}