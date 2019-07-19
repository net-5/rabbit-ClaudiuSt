using System;

namespace StringsHomework6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that to remove a newline.

            string text = "This is not a text. \n This is not me. \n This is ";
            text = text.Replace("\n", "");
            Console.Write(text);
        }
    }
}
