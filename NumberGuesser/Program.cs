using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int wylosowana = random.Next(0, 10);
            Console.WriteLine("wylosowano "+wylosowana);

          
        }

        
    }
}
