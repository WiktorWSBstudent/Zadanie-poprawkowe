using System;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {

                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
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

        Console.WriteLine("losowe liczby: " + string.Join(", ", array));

        BubbleSort(array);

        Console.WriteLine("posortowane liczby: " + string.Join(", ", array));
    }
}