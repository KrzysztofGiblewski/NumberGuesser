using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
            string liczbaGracza;
           // imie= PobierzImie();
           // WyswietlTekst("Cześć "+imie);
            WyswietlTekst("a teraz wylosóje liczbę którą masz zgadnąć");
            int wylosowanaLiczba = Losoj();
            string liczba = wylosowanaLiczba.ToString();
            liczbaGracza = "100"; // tak tymczasowo zeby nie byla pusta
            while (liczbaGracza != liczba)
               {
                WyswietlTekst("no nie poszło próbuj dalej");
                liczbaGracza = PobierzLiczbe();
                    if (liczbaGracza == liczba)
                    {
                        WyswietlTekst("BRAWOOOOO");
                        break;
                    }
                continue;
            }
             
               

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

        static string PobierzLiczbe()
        {
            Console.WriteLine("podaj liczbę");
            string liczbaGracza = Console.ReadLine();
            return liczbaGracza;
        }

    }
}
