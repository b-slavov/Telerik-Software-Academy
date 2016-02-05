using System;

class XExpression
{
    static void Main()
    {
        string expression = Console.ReadLine();

        decimal result = 0;
        decimal currentBracketsResult = 0;
        char currentOperator = '+';
        char currentBracketsOperator = '+';
        bool inBrackets = false;

        foreach (char symbol in expression)
        {
            if (symbol == '(')
            {
                inBrackets = true;
                continue;
            }

            if (symbol == ')')
            {
                inBrackets = false;
                switch (currentBracketsOperator)
                {
                    case '+': currentBracketsResult += currentBracketsResult; break;
                    case '-': currentBracketsResult -= currentBracketsResult; break;
                    case '*': currentBracketsResult *= currentBracketsResult; break;
                    case '/': currentBracketsResult /= currentBracketsResult; break;
                }

                currentBracketsResult = 0;
                currentBracketsOperator = '+';
            }

            if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
            {
                if (inBrackets)
                {
                    currentBracketsOperator = symbol;
                }
                else
                {
                    currentOperator = symbol;
                }
            }

            if (char.IsDigit(symbol))
            {
                int currentNumber = symbol - '0';
                if (inBrackets)
                {
                    switch (currentBracketsOperator)
                    {
                        case '+': currentBracketsResult += currentNumber; break;
                        case '-': currentBracketsResult -= currentNumber; break;
                        case '*': currentBracketsResult *= currentNumber; break;
                        case '/': currentBracketsResult /= currentNumber; break;
                    }
                }
                else
                {
                    switch (currentOperator)
                    {
                        case '+': result += currentNumber; break;
                        case '-': result -= currentNumber; break;
                        case '*': result *= currentNumber; break;
                        case '/': result /= currentNumber; break;
                    }
                }
            }
        }

        Console.WriteLine("{0:F2}", result);
    }
}