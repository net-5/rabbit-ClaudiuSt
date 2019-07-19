using System;
using System.Text;

namespace StringsHomework7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Neterminat

            //Write a method to display formatted text (width=50) as output. For example:
            //If I have a text that's 134 characters long, the formatted string should have maximum 
            //of 50 characters per line. In this case we will have 3 lines of text.

            Console.WriteLine("Write a string:");
            string story = Console.ReadLine();
            string story1 = $"{ story, 5 }";
            Console.WriteLine(story1);
            
        }
    }
}
