namespace Zadanie3
{
    enum KlasaRzadkosci
    {
        Powrzechny,
        Rzadki,
        Unikalny,
        Epicki
    }
    enum TypPrzedmiotu
    {
        Bron,
        Zbroja,
        Amulet,
        Pierscien,
        Helm,
        Tarcza,
        Buty
    }
    struct Przedmiot
    {
        public float Waga;
        public int Wartosc;
        public string Nazwa;
        public KlasaRzadkosci Rzadkosc;
        public TypPrzedmiotu Typ;
    }
    class Program
    {
        static void Wypelnij(ref Przedmiot PrzedmiotDoWypelnienia,
            float Waga,
            int Wartosc,
            string Nazwa,
            KlasaRzadkosci Rzadkosc,
            TypPrzedmiotu Typ)
        {
            if (Waga >= 0)
            {
                PrzedmiotDoWypelnienia.Waga = Waga;
            }
            else
            {
                PrzedmiotDoWypelnienia.Waga = 0;
            }

            if (Wartosc >= 0)
            {
                PrzedmiotDoWypelnienia.Wartosc = Wartosc;
            }
            else
            {
                PrzedmiotDoWypelnienia.Wartosc = 0;
            }

            PrzedmiotDoWypelnienia.Nazwa = Nazwa;
            PrzedmiotDoWypelnienia.Rzadkosc = Rzadkosc;
            PrzedmiotDoWypelnienia.Typ = Typ;
        }
        static void Wyswietl(Przedmiot Przedmiot)
        {
            Console.WriteLine($"Przedmiot: {Przedmiot.Nazwa}");
            Console.WriteLine($"Wartosc: {Przedmiot.Wartosc}");
            Console.WriteLine();
        }

        static Przedmiot LosujPrzedmiot(Przedmiot[] Skrzynka)
        {
            Random random = new Random();

            Array.Sort(Skrzynka, PorownajPrzedmioty);

            int sumaRzadkosci = 0;
            foreach (Przedmiot przedmiot in Skrzynka)
            {
                sumaRzadkosci += (int)przedmiot.Rzadkosc;
            }

            int losowanaRzadkosc = random.Next(1, sumaRzadkosci + 1);
            int aktualnaSuma = 0;

            foreach (var przedmiot in Skrzynka)
            {
                aktualnaSuma += (int)przedmiot.Rzadkosc;
                if (aktualnaSuma >= losowanaRzadkosc)
                {
                    return przedmiot;
                }
            }
            return Skrzynka[0];
        }

        static int PorownajPrzedmioty(Przedmiot p1, Przedmiot p2)
        {
            if (p1.Rzadkosc < p2.Rzadkosc)
                return -1;
            else if (p1.Rzadkosc == p2.Rzadkosc)
                return 0;
            else
                return 1;
        }
        static void Main(string[] args)
        {
            Przedmiot[] przedmioty = new Przedmiot[7];

            Wypelnij(ref przedmioty[0], 1.5f, 12, "Drewnian proteza nogi", KlasaRzadkosci.Powrzechny, TypPrzedmiotu.Bron);
            Wypelnij(ref przedmioty[1], 2.5f, 1000, "Pierścień regeneracji many", KlasaRzadkosci.Unikalny, TypPrzedmiotu.Pierscien);
            Wypelnij(ref przedmioty[2], 0.6f, 133000, "Koszulka Beliara", KlasaRzadkosci.Epicki, TypPrzedmiotu.Zbroja);
            Wypelnij(ref przedmioty[3], 1.8f, 870, "Kolczaste buty", KlasaRzadkosci.Rzadki, TypPrzedmiotu.Buty);
            Wypelnij(ref przedmioty[4], 0.5f, 20, "Dziurawe wiadro", KlasaRzadkosci.Powrzechny, TypPrzedmiotu.Helm);
            Wypelnij(ref przedmioty[5], 1.2f, 10, "Stara tarcza", KlasaRzadkosci.Powrzechny, TypPrzedmiotu.Tarcza);
            Wypelnij(ref przedmioty[6], 0.1f, 90000, "Łza Hansa", KlasaRzadkosci.Epicki, TypPrzedmiotu.Amulet);

            Przedmiot wylosowany = LosujPrzedmiot(przedmioty);

            Wyswietl(wylosowany);
        }
    }
}
