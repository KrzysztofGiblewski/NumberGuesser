using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
            int liczbaGracza;       // liczba ktora podaje gracz
            int wylosowanaLiczba;   // liczba wylosowana przez komputer
            imie = PobierzImie();
            WyswietlTekst($"Cześć {imie}");
            WyswietlTekst($"a teraz wylosóje liczbę którą masz zgadnąć a ty {imie} podaj swoją odpowiedź");
            wylosowanaLiczba = Losoj();
            liczbaGracza = PobierzLiczbe();
            
            while (wylosowanaLiczba != liczbaGracza)            // dopuki nie trafiam 
            {
                if (wylosowanaLiczba > liczbaGracza)
                    WyswietlTekst($"próbuj dalej twoja {liczbaGracza} to za mało");
                if (wylosowanaLiczba < liczbaGracza)
                    WyswietlTekst($"próbuj dalej twoja {liczbaGracza} to za dużo");
                liczbaGracza = PobierzLiczbe();
            }
            if (liczbaGracza == wylosowanaLiczba)
                 WyswietlTekst($"BRAWOOOOO trafiłeś :) wylosowana liczba to {wylosowanaLiczba}");
            }

        static void WyswietlTekst(string tekst)
        {
            Console.WriteLine( tekst);

        }

        static string PobierzImie()
        {
            Console.WriteLine("podaj swoje imię");
            string imie = Console.ReadLine();
            return imie;
        }
        static int Losoj()
        {
            Random random = new Random();
            int wylosowana = random.Next(0, 10);
            return wylosowana;
        }

        static int PobierzLiczbe()
        {
            string liczbaGraczaString;
            int liczbaGracza;
            Console.WriteLine("podaj liczbę");
            liczbaGraczaString = Console.ReadLine();
            liczbaGracza = int.Parse(liczbaGraczaString);
            return liczbaGracza;
        }

    }
}
