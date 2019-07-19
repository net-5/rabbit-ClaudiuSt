using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that to remove the characters which have odd index values of a given string.
            var text = "This is not my homework";
           for(int i=0; i < text.Length; i++)
            {
                if(i % 2 != 1)
                    Console.Write(text[i]);
            }

        }
    }
}
