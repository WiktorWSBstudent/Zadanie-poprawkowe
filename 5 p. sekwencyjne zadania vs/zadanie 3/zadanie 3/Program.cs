using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta(liczbę wierszy) ");
        int height = Convert.ToInt32(Console.ReadLine());

        int maxWidth = height * 2 - 1;
        int spaces = maxWidth / 2;

        for (int row = 1; row <= height; row++)
        {
            for (int space = 1; space <= spaces; space++)
            {
                Console.Write(" ");
            }

            for (int plus = 1; plus <= row * 2 - 1; plus++)
            {
                Console.Write("+");
            }

            Console.WriteLine();
            spaces--;
        }
    }
}