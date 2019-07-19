using System;
using System.Text.RegularExpressions;

namespace StringsHomework11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clean the text
            string text = "Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";
            string clean = Regex.Replace(text, "[ ^, >, <, +, %, &, $, @]", " ");
            Console.WriteLine(clean);
               
        }
    }
}
