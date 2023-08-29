using System;

class Program
{
    static void Main()
    {
        Console.Write("ile liczb wypisać? ");
        int n = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int count = 0;
        string liczbyparzyste = "";

        while (count < n)
        {
            int number = random.Next(-8, 9);
            if (number % 2 == 0)
            {
                liczbyparzyste += number + ", ";
                count++;
            }
        }

        liczbyparzyste = liczbyparzyste.TrimEnd(',', ' ');

        Console.WriteLine($"Liczby parzyste z przedziału [-8, 8]: {liczbyparzyste}");
    }
}