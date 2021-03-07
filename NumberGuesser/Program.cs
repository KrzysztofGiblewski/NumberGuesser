using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
            int liczbaGracza;
            imie= PobierzImie();
            WyswietlTekst("Cześć "+imie);
            WyswietlTekst($"a teraz wylosóje liczbę którą masz zgadnąć a ty {imie} podaj swoją odpowiedź");
            int wylosowanaLiczba = Losoj();
            liczbaGracza = PobierzLiczbe();
            while (wylosowanaLiczba != liczbaGracza)
            {
                if (wylosowanaLiczba > liczbaGracza)
                    WyswietlTekst("no za mało próbuj dalej");
                if (wylosowanaLiczba < liczbaGracza)
                    WyswietlTekst("no za dużo próbuj dalej");
                liczbaGracza = PobierzLiczbe();
            }
            if (liczbaGracza == wylosowanaLiczba)
                 WyswietlTekst("BRAWOOOOO trafiłeś :)");
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
