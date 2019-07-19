using System;

namespace StringsHomework10
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Write a method that strips a set of characters from a string.
            Console.WriteLine("Enter a string:");
            string letter = Console.ReadLine();
            Console.WriteLine("What characters you whant to strip from the string?");
            string remove = Console.ReadLine();
            if (letter != null)
            {
            letter = letter.Replace(remove, "");
                    
            }
            Console.WriteLine(letter);
            



        }
    }
}
