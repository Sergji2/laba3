using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter coordinates and names of points for the figure:");

        Console.Write("Point A - X: ");
        if (!double.TryParse(Console.ReadLine(), out double xA))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for X coordinate of Point A.");
            return;
        }

        Console.Write("Point A - Y: ");
        if (!double.TryParse(Console.ReadLine(), out double yA))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for Y coordinate of Point A.");
            return;
        }

        Console.Write("Point A - Name: ");
        string nameA = Console.ReadLine();

        Console.Write("Point B - X: ");
        if (!double.TryParse(Console.ReadLine(), out double xB))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for X coordinate of Point B.");
            return;
        }

        Console.Write("Point B - Y: ");
        if (!double.TryParse(Console.ReadLine(), out double yB))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for Y coordinate of Point B.");
            return;
        }

        Console.Write("Point B - Name: ");
        string nameB = Console.ReadLine();

        Console.Write("Point C - X: ");
        if (!double.TryParse(Console.ReadLine(), out double xC))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for X coordinate of Point C.");
            return;
        }

        Console.Write("Point C - Y: ");
        if (!double.TryParse(Console.ReadLine(), out double yC))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for Y coordinate of Point C.");
            return;
        }

        Console.Write("Point C - Name: ");
        string nameC = Console.ReadLine();

        Point pointA = new Point(xA, yA, nameA);
        Point pointB = new Point(xB, yB, nameB);
        Point pointC = new Point(xC, yC, nameC);

        Figure figure = new Figure(pointA, pointB, pointC);

        figure.CalculatePerimeter();
    }
}
