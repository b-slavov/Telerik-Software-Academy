namespace BooleanToString
{
    using System;

    internal class BooleanToString
    {
        public void Converter(bool inputVariable)
        {
            string variableAsString = inputVariable.ToString();
            Console.WriteLine(variableAsString);
        }
    }
}
