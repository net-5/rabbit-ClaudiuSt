using System;

namespace StringHomework9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that reverses a string.
            Console.Write("Enter your string: ");
            string text;
            text = Console.ReadLine();

            char[] reverseFirst = text.ToCharArray();
            Array.Reverse(reverseFirst);
                Console.WriteLine(reverseFirst);
        }
    }
}
