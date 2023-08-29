using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wprowadź wartość x: ");
        double x;
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Nieprawidłowe dane wejściowe. Proszę wprowadzić poprawną liczbę rzeczywistą.");
            Console.Write("Wprowadź wartość x: ");
        }

        int n = ReadPositiveInteger("Podaj liczbę terminów (n): ");

        double estimatedValue = EstimateExponentialFunction(x, n);
        Console.WriteLine($"Szacowa wartość e^{x} używając {n} terminów: {estimatedValue}");
    }

    static int ReadPositiveInteger(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                return number;
            }
            Console.WriteLine("Nieprawidłowe dane wejściowe. Proszę wprowadzić dodatnią liczbę całkowitą.");
        }
    }

    static double EstimateExponentialFunction(double x, int n)
    {
        double result = 1.0; 

        for (int i = 1; i <= n; i++)
        {
            double term = Math.Pow(x, i) / CalculateFactorial(i);
            result += term;
        }

        return result;
    }

    static long CalculateFactorial(int number)
    {
        long factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}