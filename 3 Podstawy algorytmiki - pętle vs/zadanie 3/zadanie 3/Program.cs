using System;

class Program
{
    static void Main(string[] args)
    {
        int n = ReadNaturalNumber("Wprowadź wartość n (nie mniej niż 5): ", 5);
        int k = ReadNaturalNumber("Wprowadź wartość k (nie mniej niż 5): ", 5);

        long nFactorial = CalculateFactorial(n);
        long kFactorial = CalculateFactorial(k);

        long m = (nFactorial - kFactorial) / kFactorial;

        Console.WriteLine($"Wynik: m = {m}");
    }

    static int ReadNaturalNumber(string prompt, int minValue)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number) && number >= minValue)
            {
                return number;
            }
            Console.WriteLine($"Nieprawidłowe dane wejściowe. Proszę wpisać liczbę naturalną nie mniejszą niż {minValue}.");
        }
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