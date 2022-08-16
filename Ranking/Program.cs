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
            var contestsData = new Dictionary<string, string>();
            string contestsDataInput;
            while((contestsDataInput = Console.ReadLine()) != "end of contests")
            {
                string[] dataSplitter = contestsDataInput.Split(":");
                string contest = dataSplitter[0];
                string passwordForContest = dataSplitter[1];
                contestsData.Add(contest, passwordForContest);
            }

            var data = new Dictionary<string, List<string>>();
            string mainInput;
            while ((mainInput = Console.ReadLine()) != "end of submissions")
            {
                string[] dataSplitter = mainInput.Split("=>");
                string contest = dataSplitter[0];
                string password = dataSplitter[1];
                string username = dataSplitter[2];
                string points = dataSplitter[3];
                data.Add(contest, new List<string>());
                data[contest].Add(password);
                data[contest].Add(username);
                data[contest].Add(points);
            }
        }
    }
}
