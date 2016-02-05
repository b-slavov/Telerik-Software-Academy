using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your birthdate (mm.dd.yyyy): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        int age = (int)((DateTime.Now - birthDate).TotalDays / 365.242199);

        Console.WriteLine("Your age is: " + age);
        Console.WriteLine("Your age after 10 years will be: " + (age + 10));
    }
}