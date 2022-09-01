using System;
using System.Text.RegularExpressions;

namespace KeepFirstOccurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "like for example $ you don't have $ network $ access";
            Console.WriteLine("before: {0}", s);

            GroupCollection halves = Regex.Match(s, @"([^$]*\$)(.*)").Groups;
            string answer = halves[1].Value + halves[2].Value.Replace("$", "");

            Console.WriteLine("after: {0}", answer);
            // like for example $  you don't have   network   access

            string s2 = "ignored2 [john] John Johnson";
            GroupCollection halves2 = Regex.Match(s2, @"\[(.*?)\](.*)").Groups;
            
            Console.WriteLine(halves2[1]);
        }
    }
}
