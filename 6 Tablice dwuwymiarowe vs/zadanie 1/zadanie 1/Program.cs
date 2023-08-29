using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[10, 10];

        for (int row = 0; row < 10; row++)
        {
            if (row % 2 == 0)
            {
                
                for (int col = 0; col < 10; col++)
                {
                    array[row, col] = (row * 10) + col + 1;
                }
            }
            else
            {
                
                for (int col = 9; col >= 0; col--)
                {
                    array[row, col] = (row * 10) + (9 - col) + 1;
                }
            }
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