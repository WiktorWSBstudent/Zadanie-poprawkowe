using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj wielkość (ilość kolumn i rzędów): ");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.WriteLine("Error. Wprowadź dodatnią liczbę całkowitą.");
            Console.Write("Podaj wielkość (ilość kolumn i rzędów): ");
        }

        int[,] array = new int[size, size];

        for (int row = 0; row < size; row++)
        {
            if (row % 2 == 0)
            {

                for (int col = 0; col < size; col++)
                {
                    array[row, col] = (row * size) + col + 1;
                }
            }
            else
            {

                for (int col = size - 1; col >= 0; col--)
                {
                    array[row, col] = (row * size) + (size - col);
                }
            }
        }


        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write(array[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }
}