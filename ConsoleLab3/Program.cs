using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of two sides of the rectangle:");

        Console.Write("Side 1: ");
        if (!double.TryParse(Console.ReadLine(), out double side1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for side 1.");
            return;
        }

        Console.Write("Side 2: ");
        if (!double.TryParse(Console.ReadLine(), out double side2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for side 2.");
            return;
        }

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Rectangle Perimeter: {rectangle.Perimeter}");
        Console.WriteLine($"Rectangle Area: {rectangle.Area}");

    }
}
