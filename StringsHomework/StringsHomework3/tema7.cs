using System;

namespace StringsHomework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that takes input from the user and displays that input back in upper and lower cases.
            string text;
            Console.WriteLine("Please enter your text:");
            text = Console.ReadLine();
            string text1 = text.ToUpper();
            string text2 = text1.ToLower();
            Console.WriteLine($"{text1} \n {text2}");
        




        }
    }
}
