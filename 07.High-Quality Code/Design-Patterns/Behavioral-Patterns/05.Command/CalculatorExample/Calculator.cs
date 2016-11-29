namespace Command.CalculatorExample
{
    using System;

    public class Calculator
    {
        private decimal currentValue;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    this.currentValue += operand;
                    break;
                case '-':
                    this.currentValue -= operand;
                    break;
                case '*':
                    this.currentValue *= operand;
                    break;
                case '/':
                    this.currentValue /= operand;
                    break;
            }

            Console.WriteLine($"Current value = {this.currentValue,3} (following {@operator} {operand})");
        }
    }
}
