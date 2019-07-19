using System;

namespace StringsHomework8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that formats a number with a percentage
            Console.WriteLine("Write a number:");
            string number = Console.ReadLine();
            Console.WriteLine(string.Format("{0}%", number));

        }
    }
}
