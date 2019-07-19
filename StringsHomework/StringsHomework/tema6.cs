using System;

namespace StringsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that to remove the nth index character from a nonempty string.
            string work = "This is my homework";
            string remove = work.Remove(1, 1);  // we remove index 1 , 1 char. 
            Console.WriteLine(remove);

        }
    }
}
