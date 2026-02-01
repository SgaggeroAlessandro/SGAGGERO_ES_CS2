using System;
namespace Es2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int c = 0;
            Console.WriteLine("Inserisci un numero");
            int.TryParse(Console.ReadLine(), out N);

            while (N <= 0)
            {
                Console.WriteLine("Il numero deve essere positivo");
                Console.WriteLine("Inserisci un numero");
                int.TryParse(Console.ReadLine(), out N);
            }
            while (N > 1)
            {
                if (N % 2 == 0)
                {
                    N = N / 2;
                }
                else
                {
                    N = N * 3 + 1;
                }
                Console.WriteLine(N);
                c++;
            }
            Console.WriteLine("Numero totale passaggi:" + c);
        }

    }
}
