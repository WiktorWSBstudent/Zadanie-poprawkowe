using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj podstawę (liczbę naturalną): ");
        int baseNumber;
        while (!int.TryParse(Console.ReadLine(), out baseNumber) || baseNumber < 0)
        {
            Console.WriteLine("Nieprawidłowe dane wejściowe. Wprowadź nieujemną wartość całkowitą.");
            Console.Write("Podaj podstawę (liczbę naturalną): ");
        }

        Console.Write("Podaj wykładnik (liczbę naturalną): ");
        int exponent;
        while (!int.TryParse(Console.ReadLine(), out exponent) || exponent < 0)
        {
            Console.WriteLine("Nieprawidłowe dane wejściowe. Wprowadź nieujemną wartość całkowitą.");
            Console.Write("Podaj wykładnik (liczbę naturalną): ");
        }

        long result = Exponentiate(baseNumber, exponent);
        Console.WriteLine($"{baseNumber}^{exponent} = {result}");
    }

    static long Exponentiate(int baseNumber, int exponent)
    {
        long result = 1;

        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }

        return result;
    }
}