using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wpisz liczbę (n): ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Nieprawidłowe dane wejściowe. Proszę wprowadzić dodatnią liczbę całkowitą.");
            Console.Write("Wpisz liczbę (n): ");
        }

        Console.WriteLine($"Pary liczb naturalnych, których suma wynosi {n}:");

        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine($"({i}, {j})");
        }
    }
}