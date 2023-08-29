using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pomyśl o liczbie od 1 do 20, którą program spróbuje odgadnąć");
        Console.WriteLine("   - Wpisz -1, jeśli moje przypuszczenia są zbyt niskie.");
        Console.WriteLine("   - Wpisz 1, jeśli moje przypuszczenie jest zbyt wysokie.");
        Console.WriteLine("   - Wpisz 0, jeśli moje przypuszczenia są prawidłowe.");

        int lowerBound = 1;
        int upperBound = 20;

        while (true)
        {
            int guess = (lowerBound + upperBound) / 2;
            Console.WriteLine($"Czy to twoja liczba {guess}?");

            int userResponse = int.Parse(Console.ReadLine());

            if (userResponse == -1)
            {
                lowerBound = guess + 1;
            }
            else if (userResponse == 1)
            {
                upperBound = guess - 1;
            }
            else if (userResponse == 0)
            {
                Console.WriteLine($"program odgadł liczbę była nią: {guess}");
                break;
            }
            else
            {
                Console.WriteLine("Nieprawidłowe dane wejściowe. Wprowadź -1, 0 lub 1.");
            }
        }
    }
}