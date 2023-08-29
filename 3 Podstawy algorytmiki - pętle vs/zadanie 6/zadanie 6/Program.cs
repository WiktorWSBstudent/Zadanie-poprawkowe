using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wpisz numer: ");
        int x;
        while (!int.TryParse(Console.ReadLine(), out x) || x <= 0)
        {
            Console.WriteLine("Nieprawidłowe dane wejściowe. Proszę wprowadzić dodatnią liczbę całkowitą.");
            Console.Write("Wpisz numer: ");
        }

        int n = FindFactorialNumber(x);

        if (n != -1)
        {
            Console.WriteLine($"{x} jest silnią {n}");
        }
        else
        {
            Console.WriteLine($"{x} nie jest silnią żadnej liczby");
        }
    }

    static int FindFactorialNumber(int x)
    {
        int n = 1;
        int factorial = 1;

        while (factorial < x)
        {
            n++;
            factorial *= n;
        }

        if (factorial == x)
        {
            return n;
        }
        else
        {
            return -1;
        }
    }
}