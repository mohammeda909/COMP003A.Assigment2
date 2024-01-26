

using System;

class Program
{
    static void Main()
    {
        // Author: [mohammed ali]
        // Course: [COMP003AL01]
        // Purpose: [learning programmning basics]     
        Console.Title = "COMP-003A - Assignment 2";
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Enter your First Name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter your Middle Name:");
        string middleName = Console.ReadLine();
        Console.WriteLine("Enter your Last Name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter your Age in 2023:");
        string inputAge = Console.ReadLine();
        int yearBorn = 2023 - Convert.ToInt32(inputAge);
        Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");
        Console.WriteLine("Enter an integer:");
        int integer1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another integer:");
        int integer2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
        Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
        Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
        Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
        Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");
        Console.WriteLine("Enter a radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        double circumference = 2 * Math.PI * radius;
        Console.WriteLine($"The area{radius} is {area:F2}");
        Console.WriteLine($"The circumference {radius} is {circumference:F2}");
    }
}

