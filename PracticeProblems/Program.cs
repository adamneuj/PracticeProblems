using System;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            string name = "Adam";
            string reverse = ReverseString.Reverse(name);
            Console.WriteLine(reverse);
        }
    }
}
