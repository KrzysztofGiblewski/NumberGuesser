using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
           imie= PobierzImie();
            WyswietlTekst("Cześć "+imie);
            WyswietlTekst("a teraz wylosóje liczbę którą masz zgadnąć");
            int wylosowanaLiczba = Losoj();

            WyswietlTekst("wylosowano");
            string liczba = wylosowanaLiczba.ToString();
            WyswietlTekst(liczba);
            WyswietlTekst($"kolejną {imie} zgadniesz ty");
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

    }
}
