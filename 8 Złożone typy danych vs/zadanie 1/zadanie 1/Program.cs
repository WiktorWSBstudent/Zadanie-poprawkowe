using System;

namespace Zadanie1
{
    enum DaysOfWeek
    {
        Poniedziałek,
        Wtorek,
        Środa,
        Czwartek,
        Piątek,
        Sobota,
        Niedziela
    }

    enum WashingMachineStages
    {
       Pranie,
       Płukanie,
       Wirowanie
    }

    enum MealsDuringDay
    {
        Śniadanie,
        Obiad,
        Kolacja
    }

    enum ChessPieces
    {
      Pion,
      Skoczek,
      Goniec,
      Wieża,
      Królowa,
      Król
    }

    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Niedziela;
            WashingMachineStages currentStage = WashingMachineStages.Płukanie;
            MealsDuringDay currentMeal = MealsDuringDay.Obiad;
            ChessPieces piece = ChessPieces.Goniec;

            Console.WriteLine($"Dzień - {today}");
            Console.WriteLine($"Etap prania - {currentStage}");
            Console.WriteLine($"Posiłek - {currentMeal}");
            Console.WriteLine($"figura szachowa - {piece}");
        }
    }
}