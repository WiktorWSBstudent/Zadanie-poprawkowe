using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        Random random = new Random();


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100);
        }


        int largest = array[0];
        int smallest = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > largest)
            {
                largest = array[i];
            }

            if (array[i] < smallest)
            {
                smallest = array[i];
            }
        }


        Console.WriteLine("Wszystkie liczby: " + string.Join(", ", array));
        Console.WriteLine("Największa liczba: " + largest);
        Console.WriteLine("Najmniejsza liczba: " + smallest);
    }
}