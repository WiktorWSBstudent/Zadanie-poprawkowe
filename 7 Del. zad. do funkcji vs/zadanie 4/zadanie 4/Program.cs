using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array =
        {
                {1, 2, 3, 4, 5 },
                {6, 7, 8, 9, 0 },
                {10, 11, 12, 13, 14 },
                {1, 3, 3, 4, 5 }
            };
        FindMostSimilarRows(array, out int row1, out int row2);
        Console.WriteLine($"Najbardziej podobne wiersze to: {row1} i {row2}");
    }

    static void FindMostSimilarRows(int[,] array, out int row1, out int row2)
    {
        row1 = 0;
        row2 = 0;

        long smallestDifference = long.MaxValue;

        int rowCount = array.GetLength(0);
        int columnCount = array.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = i + 1; j < rowCount; j++)
            {
                long difference = CalculateDifference(array, i, j);
                if (difference < smallestDifference)
                {
                    smallestDifference = difference;
                    row1 = i;
                    row2 = j;
                }
            }
        }
    }

    static long CalculateDifference(int[,] array, int i, int j)
    {
        int columnCount = array.GetLength(1);
        long difference = 0;

        for (int col = 0; col < columnCount; col++)
        {
            difference += (long)Math.Pow(array[i, col] - array[j, col], 2);
        }

        return difference;
    }
}