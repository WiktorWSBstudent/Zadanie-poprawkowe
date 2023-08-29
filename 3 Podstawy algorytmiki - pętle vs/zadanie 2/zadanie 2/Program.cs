using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wprowadź liczbę wyrazów Fibonacciego do wydrukowania: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Nieprawidłowe dane wejściowe. Proszę wprowadzić dodatnią wartość całkowitą.");
            Console.Write("Wprowadź liczbę wyrazów Fibonacciego do wydrukowania: ");
        }

        PrintFibonacciSequence(n);
    }

    static void PrintFibonacciSequence(int n)
    {
        int firstTerm = 0, secondTerm = 1, nextTerm;

        Console.Write($"Pierwsze {n} wyrazy Fibonacciego: ");

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{firstTerm} ");

            nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }

        Console.WriteLine();
    }
}