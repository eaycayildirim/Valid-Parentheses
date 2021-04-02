using System;
using Parentheses;

namespace ValidParenthesesMain
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidParentheses valid = new ValidParentheses();
            valid.IsInputValid(valid.AskTheString());
        }
    }
}
