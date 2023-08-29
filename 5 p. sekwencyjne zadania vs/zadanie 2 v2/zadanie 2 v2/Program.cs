using System;

class Program
{
    static void Main()
    {
        Console.Write("Ile liczb wypisać? ");
        int n = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int count = 0;
        string liczbyparzyste = "";

        while (count < n)
        {
            int number;
            do
            {
                number = random.Next(-8, 9);
            } while (number % 2 != 0);

            liczbyparzyste += number + ", ";
            count++;
        }


        liczbyparzyste = liczbyparzyste.TrimEnd(',', ' ');

        Console.WriteLine($"liczby parzyste w przedziale [-8, 8]: {liczbyparzyste}");
    }
}