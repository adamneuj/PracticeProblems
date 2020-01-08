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

        public static string ConvertToNumeral(int number)
        {
            int sum = number;
            string romanNumeral = "";
            while (sum != 0)
            {
                if (sum >= 1000)
                {
                    sum -= 1000;
                    romanNumeral += "M";
                }
                else if (sum >= 500 && sum < 1000)
                {
                    if(sum >= 900)
                    {
                        sum -= 900;
                        romanNumeral += "CM";
                    }
                    else
                    {
                        sum -= 500;
                        romanNumeral += "D";
                    }
                }
                else if (sum >= 100 && sum < 500)
                {
                    if (sum >= 400)
                    {
                        sum -= 400;
                        romanNumeral += "CD";
                    }
                    else
                    {
                        sum -= 100;
                        romanNumeral += "C";
                    }
                }
                else if (sum >= 50 && sum < 100)
                {
                    if (sum >= 90)
                    {
                        sum -= 90;
                        romanNumeral += "XC";
                    }
                    else
                    {
                        sum -= 50;
                        romanNumeral += "L";
                    }
                }
                else if (sum >= 10 && sum < 50)
                {
                    if (sum >= 40)
                    {
                        sum -= 40;
                        romanNumeral += "XL";
                    }
                    else
                    {
                        sum -= 10;
                        romanNumeral += "X";
                    }
                }
                else if(sum >= 5 && sum < 10)
                {
                    if (sum == 9)
                    {
                        sum -= 9;
                        romanNumeral += "IX";
                    }
                    else
                    {
                        sum -= 5;
                        romanNumeral += "V";
                    }
                }
                else if(sum >= 1 && sum < 5)
                {
                    if (sum == 4)
                    {
                        sum -= 4;
                        romanNumeral += "IV";
                    }
                    else
                    {
                        sum -= 1;
                        romanNumeral += "I";
                    }
                }
            }
            return romanNumeral;
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
