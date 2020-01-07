using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
    static class ReverseString
    {
        public static string Reverse(string String)
        {
            string reverse = "";
            for(int i = String.Length - 1; i >= 0; i--)
            {
                reverse += String[i];
            }
            return reverse;
        }
    }
}
