using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[10, 10];

        int num = 1;
        int topRow = 0;
        int bottomRow = 9;
        int leftCol = 0;
        int rightCol = 9;

        while (num <= 100)
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


        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write(array[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }
}