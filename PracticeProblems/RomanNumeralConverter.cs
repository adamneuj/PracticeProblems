using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    static class RomanNumeralConverter
    {
        public static int ConvertToInt(string numeral)
        {
            int sum = 0;
            for(int i = 0; i < numeral.Length; i++)
            {
                int symbol1 = GetValue(numeral[i]);
                if(i + 1 < numeral.Length)
                {
                    int symbol2 = GetValue(numeral[i + 1]);
                    if(symbol1 >= symbol2)
                    {
                        sum += symbol1;
                    }
                    else
                    {
                        sum += symbol2 - symbol1;
                        i++;
                    }
                }
                else
                {
                    sum += symbol1;
                }
            }
            return sum;
        }

        public static int GetValue(char value)
        {
            if(value == 'I')
            {
                return 1;
            }
            else if(value == 'V')
            {
                return 5;
            }
            else if(value == 'X')
            {
                return 10;
            }
            else if (value == 'L')
            {
                return 50;
            }
            else if (value == 'C')
            {
                return 100;
            }
            else if (value == 'D')
            {
                return 500;
            }
            else if (value == 'M')
            {
                return 1000;
            }
            else
            {
                return 0;
            }
        }
    }
}
