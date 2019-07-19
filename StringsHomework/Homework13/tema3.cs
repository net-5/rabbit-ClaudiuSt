using System;

namespace Homework13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method to get the last part of a string before a specified character.
            // Input :  https://www.siit.com/net-exercises
            // Output:  https://www.siit.com/net

            string s = "https://www.siit.com/net-exercises";
            Console.WriteLine(s.Split('-')[0]);

            Console.ReadKey();
        }
    }
}
