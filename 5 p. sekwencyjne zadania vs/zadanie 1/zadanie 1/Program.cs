using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static bool LP(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Podaj ile liczb pierwszych chcesz otrzymać: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int number = 2;

        Console.WriteLine($"Pierwsze {n} liczby pierwsze:");

        while (count < n)
        {
            if (LP(number))
            {
                Console.WriteLine(number);
                count++;
            }
            number++;
        }
    }
}