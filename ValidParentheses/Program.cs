using System;
using Parentheses;

namespace ValidParenthesesMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "[()()]";

            ValidParentheses valid = new ValidParentheses();
            valid.isInputValid(input);
        }
    }
}
