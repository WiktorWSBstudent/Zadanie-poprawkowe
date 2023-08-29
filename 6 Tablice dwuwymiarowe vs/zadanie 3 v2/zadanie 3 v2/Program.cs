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

        int num = 1;
        int topRow = 0;
        int bottomRow = size - 1;
        int leftCol = 0;
        int rightCol = size - 1;

        while (num <= size * size)
        {
            for (int col = leftCol; col <= rightCol; col++)
            {
                array[topRow, col] = num++;
            }
            topRow++;

            for (int row = topRow; row <= bottomRow; row++)
            {
                array[row, rightCol] = num++;
            }
            rightCol--;

            for (int col = rightCol; col >= leftCol; col--)
            {
                array[bottomRow, col] = num++;
            }
            bottomRow--;

            for (int row = bottomRow; row >= topRow; row--)
            {
                array[row, leftCol] = num++;
            }
            leftCol++;
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