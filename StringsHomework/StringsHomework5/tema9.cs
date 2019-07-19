using System;

namespace StringsHomework5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method to convert a given string to all uppercase if it
            //contains at least 2 uppercase characters in the first 4 characters. 
            // work in progress
            string upper;
            char[] arr;
            int c, i;
            c = 0;
            char word;
            Console.WriteLine("Type a string:");
            upper = Console.ReadLine();
            c = upper.Length;
            arr = upper.ToCharArray(0, 1);
            Console.WriteLine("Your string is:");
            for (i =0; i < c; i++)
            {
                word = arr[i];
                if (Char.IsLower(word))
            }
        }
    }
}
