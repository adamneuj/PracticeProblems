using System;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Adam";
            string reverse = ReverseString.Reverse(name);
            Console.WriteLine("Original String: " + name);
            Console.WriteLine("Reversed String: " + reverse);
            Console.WriteLine();

            string numeral = "XIX";
            Console.WriteLine(RomanNumeralConverter.ConvertToInt(numeral));
        }
    }
}
