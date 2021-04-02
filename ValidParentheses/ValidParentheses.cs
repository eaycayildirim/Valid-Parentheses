using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parentheses
{
    public class ValidParentheses
    {
        private char[] openParenthesis = { '[', '(', '{' };
        private char[] closeParenthesis = { ']', ')', '}' };
        private bool result = true;

        public bool IsInputValid(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (!openParenthesis.Contains(input[i + 1]))
                {
                    if (Array.IndexOf(openParenthesis, input[i]) != Array.IndexOf(closeParenthesis, input[i + 1]))
                    {
                        result = false;
                    }
                    else
                        return result;
                }
            }
            return result;
        }

        public string AskTheString()
        {
            return Console.ReadLine();
        }
    }
}
