using System;

class Program
{
    static void Main(string[] args)
    {
        double initialAmount = ReadPositiveDouble("Wpisz kwotę początkową: ");
        double annualInterestRate = ReadPositiveDouble("Podaj roczną stopę oprocentowania (%): ");
        int numberMonths = ReadPositiveInteger("Podaj liczbę miesięcy: ");

        double monthlyInterestRate = annualInterestRate / 12 / 100;
        double amountWithInterest = initialAmount * Math.Pow(1 + monthlyInterestRate, numberMonths);
        double Tax19 = 0.81;

        double finalAmount = amountWithInterest * Tax19;

        Console.WriteLine($"Całkowita kwota po {numberMonths} miesiącach: {finalAmount:C}");
    }

    static double ReadPositiveDouble(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                return number;
            }
            Console.WriteLine("Nieprawidłowe dane wejściowe. Proszę wprowadzić liczbę dodatnią.");
        }
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
}