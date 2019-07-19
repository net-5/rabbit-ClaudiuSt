using System;
using System.Text;

namespace StringsHomework4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mai de lucrat 

            // Write a method that reverses a string if it's length is a multiple of 4

            Console.Write("Enter your string: ");
            string text;
            text = Console.ReadLine();

            char[] reverseFirst = text.ToCharArray();// we get a char array from string 
            Array.Reverse(reverseFirst);// reverse the order of the array
            foreach (int i in reverseFirst)//we put condition for what to dispaly
            {
                if ( text.Length % 4 == 0)
                    Console.Write(i);

            }
            if (text.Length % 4 == 1)
                Console.Write(text);           
        }
    }
}
