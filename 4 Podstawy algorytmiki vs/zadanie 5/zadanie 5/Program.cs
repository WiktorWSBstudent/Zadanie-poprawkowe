using System;

class Program
{
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;


            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }


            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
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

        Console.WriteLine("Nieposortowane: " + string.Join(", ", array));

        SelectionSort(array);

        Console.WriteLine("Posortowane: " + string.Join(", ", array));
    }
}