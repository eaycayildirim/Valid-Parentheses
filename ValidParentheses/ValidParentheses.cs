using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parentheses
{
    public class ValidParentheses
    {
        public string AskTheString()
        {
            return Console.ReadLine();
        }

        public void WriteTheResult()
        {
            if(IsInputValid(AskTheString()))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public bool IsInputValid(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var parentheses in input)
            {
                if (stack.Count > 0 && parentheses == ')' && stack.Peek() == '(')
                    stack.Pop();
                else if (stack.Count > 0 && parentheses == ']' && stack.Peek() == '[')
                    stack.Pop();
                else if (stack.Count > 0 && parentheses == '}' && stack.Peek() == '{')
                    stack.Pop();
                else
                    stack.Push(parentheses);
            }
            return stack.Count == 0;
            
        }
    }
}
