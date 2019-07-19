using System;

namespace StringHomework12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that takes a list of words and returns the length of the longest one.
            string[] array1 = { "Cats", "house", "Homework", "responsibility" };
            
            var longString = array1[0];

            
            foreach (var t in array1)
            {
               
                if (longString.Length < t.Length)
                    longString = t;
            }
            
            Console.WriteLine("Longest string is: " + longString);
            Console.Read();


        }
            
    }
}

