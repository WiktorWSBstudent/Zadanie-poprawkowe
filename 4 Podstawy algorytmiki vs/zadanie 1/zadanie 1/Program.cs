using System;

class Program
{
    static void PrintArrayBackwards(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static void Main(string[] args)
    {
        int[] array = new int[10];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100);
        }

        Console.WriteLine("normalna wersja:");
        Console.WriteLine(string.Join(", ", array));

        Console.WriteLine("wersja od tyłu:");
        PrintArrayBackwards(array);
    }
}
