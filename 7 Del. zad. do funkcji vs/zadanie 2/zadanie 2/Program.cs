using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wprowadź współrzędną x punktu początkowego: ");
        double startX;
        while (!double.TryParse(Console.ReadLine(), out startX))
        {
            Console.WriteLine("Error, wprowadź prawidłową liczbę rzeczywistą.");
            Console.Write("Wprowadź współrzędną x punktu początkowego: ");
        }

        Console.Write("Wprowadź współrzędną y punktu początkowego: ");
        double startY;
        while (!double.TryParse(Console.ReadLine(), out startY))
        {
            Console.WriteLine("Error, wprowadź prawidłową liczbę rzeczywistą.");
            Console.Write("Wprowadź współrzędną y punktu początkowego: ");
        }

        Console.Write("Wprowadź współrzędną x punktu końcowego: ");
        double endX;
        while (!double.TryParse(Console.ReadLine(), out endX))
        {
            Console.WriteLine("Error, wprowadź prawidłową liczbę rzeczywistą.");
            Console.Write("Wprowadź współrzędną x punktu końcowego: ");
        }

        Console.Write("Wprowadź współrzędną y punktu końcowego: ");
        double endY;
        while (!double.TryParse(Console.ReadLine(), out endY))
        {
            Console.WriteLine("Error, wprowadź prawidłową liczbę rzeczywistą.");
            Console.Write("Wprowadź współrzędną y punktu końcowego: ");
        }

        double length = CalculateLineSegmentLength(startX, startY, endX, endY);
        Console.WriteLine("Długość odcinka linii: " + length);
    }

    static double CalculateLineSegmentLength(double startX, double startY, double endX, double endY)
    {
        double deltaX = endX - startX;
        double deltaY = endY - startY;
        double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        return length;
    }
}