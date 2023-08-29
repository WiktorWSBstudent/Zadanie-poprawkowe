using System;

namespace Zadanie4
{
    enum Plec
    {
        Mezczyzna,
        Kobieta
    }

    struct Student
    {
        public string Imie;
        public int NumerAlbumu;
        public double Ocena;
        public Plec Plec;

        public void WyswietlInformacje()
        {
            string plecTekst = Plec == Plec.Mezczyzna ? "Mężczyzna" : "Kobieta";
            Console.WriteLine($"Imię: {Imie}, Numer Albumu: {NumerAlbumu}, Ocena: {Ocena}, Płeć: {plecTekst}");
        }
    }

    class Program
    {
        static void WypelnijInformacjeOStudencie(ref Student student)
        {
            Console.Write("Podaj Imię: ");
            student.Imie = Console.ReadLine();

            Console.Write("Podaj Numer Albumu: ");
            student.NumerAlbumu = int.Parse(Console.ReadLine());

            Console.Write("Podaj Ocena: ");
            double ocena = double.Parse(Console.ReadLine());

            if (ocena < 2.0)
            {
                student.Ocena = 2.0;
            }
            else if (ocena > 5.0)
            {
                student.Ocena = 5.0;
            }
            else
            {
                student.Ocena = ocena;
            }

            string plecInput;
            do
            {
                Console.Write("Podaj Płeć (m - Mezczyzna / k - Kobieta): ");
                plecInput = Console.ReadLine().ToLower();

                if (plecInput != "m" && plecInput != "k")
                {
                    Console.WriteLine("Nieprawidłowe dane. Wprowadź m lub k.");
                }
            } while (plecInput != "m" && plecInput != "k");

            student.Plec = plecInput == "m" ? Plec.Mezczyzna : Plec.Kobieta;
        }

        static double ObliczSrednia(Student[] studenci)
        {
            double suma = 0.0;

            foreach (var student in studenci)
            {
                suma += student.Ocena;
            }

            return suma / studenci.Length;
        }

        static void Main(string[] args)
        {
            Student[] grupaStudentow = new Student[5];

            for (int i = 0; i < grupaStudentow.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                WypelnijInformacjeOStudencie(ref grupaStudentow[i]);
            }

            Console.WriteLine("\nInformacje o Studentach:");
            foreach (var student in grupaStudentow)
            {
                student.WyswietlInformacje();
            }

            double srednia = ObliczSrednia(grupaStudentow);
            Console.WriteLine($"\nŚrednia Ocena: {srednia}");
        }
    }
}