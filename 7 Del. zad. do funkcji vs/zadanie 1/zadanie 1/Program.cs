using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wpisz liczbę sekund: ");
        int seconds;
        while (!int.TryParse(Console.ReadLine(), out seconds) || seconds < 0)
        {
            Console.WriteLine("wpisana liczba musi być dodatnia");
            Console.Write("wpisz liczbę sekund: ");
        }

        string formattedTime = FormatScreenTime(seconds);
        Console.WriteLine(formattedTime);
    }

    static string FormatScreenTime(int seconds)
    {
        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int remainingSeconds = seconds % 60;

        string formattedHours = hours.ToString("D2");
        string formattedMinutes = minutes.ToString("D2");
        string formattedSeconds = remainingSeconds.ToString("D2");

        string formattedTime = $"{formattedHours}:{formattedMinutes}:{formattedSeconds}";

        return formattedTime;
    }
}