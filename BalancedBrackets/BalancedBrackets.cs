using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedBrackets
{
    public static class BalancedBrackets
    {
        public static bool ExecuteValidBalancedBrackets(string expression)
        {
            string[] charactersAllowed = { "{", "}", "[", "]", "(", ")" };
            var stack = new Stack<char>();
            var symbols = expression.ToCharArray();
            if (symbols.Length == 0)
                throw new Exception("Please enter at least 1 characters");

            foreach (var temp in symbols)
            {
                if (charactersAllowed.All(x => x != temp.ToString()))
                    throw new Exception("Invalid characters");

                if (temp == '[' || temp == '{' || temp == '(')
                    stack.Push(temp);
                else
                {
                    if (stack.Count == 0)
                        return false;

                    var top = stack.Peek();
                    if (temp == ']')
                    {
                        if (top != '[')
                            break;

                        stack.Pop();
                    }
                    else if (temp == '}')
                    {
                        if (top != '{')
                            break;

                        stack.Pop();
                    }
                    else
                    {
                        if (top != '(')
                            break;

                        stack.Pop();
                    }
                }
            }
            return !stack.Any();
        }
    }
}

