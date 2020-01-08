using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    class FizzBuzz
    {
        public FizzBuzz()
        {
            Generate();
        }

        private void Generate()
        {
            string buzz = "Buzz";
            string fizz = "Fizz";
            string fizzBuzz = "FizzBuzz";
            for(int i = 0; i <= 100; i++)
            {
                if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(fizzBuzz);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(buzz);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(fizz);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
