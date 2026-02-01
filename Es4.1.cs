using System;

namespace PiramideNumeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci l'altezza N: ");
            int N = int.Parse(Console.ReadLine());

            for (int riga = 1; riga <= N; riga++)
            {
                for (int spazi = 1; spazi <= N - riga; spazi++)
                {
                    Console.Write(" ");
                }

                for (int i = 1; i <= riga; i++)
                {
                    Console.Write(i);
                }

                for (int i = riga - 1; i >= 1; i--)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }
    }
}
