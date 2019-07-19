using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method to get a string made of the first 2 and the last 2 chars from a given a string. If the string length is less than 2, return instead of the empty string.
            Console.WriteLine("Please type a word:");
            string word = Console.ReadLine();
            
            if (word.Length < 2)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine(word.Substring(0, 2) + "..." + word.Substring(word.Length -2, 2));
            }
        }
        
    }
}

