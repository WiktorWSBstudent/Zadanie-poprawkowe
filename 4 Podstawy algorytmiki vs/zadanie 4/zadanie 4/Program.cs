using System;

class Program
{
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
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

        Console.WriteLine("Losowe liczby: " + string.Join(", ", array));

        InsertionSort(array);

        Console.WriteLine("Posortowane liczby: " + string.Join(", ", array));
    }
}