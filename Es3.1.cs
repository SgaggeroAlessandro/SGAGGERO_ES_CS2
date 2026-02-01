using System;
namespace Es3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int s1 = 0;
            int s2 = 0;
            Console.WriteLine("Questo programma verifica se due conti bancari sono finanziariamente sani, usando come criterio i numeri amicali");
            Console.WriteLine("Inserisci il primo numero:");
            int.TryParse(Console.ReadLine(), out n1);
            Console.WriteLine("Inserisci il secondo numero:");
            int.TryParse(Console.ReadLine(), out n2);

    
            for(int i = 1; i <= n1; i++)
            {
                if(n1 % i == 0)
                {

                    s1 += i;
                }
            }
            for(int j = 1; j <= n2; j++)
            {
                if(n2 % j == 0)
                {
                    s2 += j;
                }
            }
            
            if(s1-n1 == n2 && s2-n2 == n1) // sottraggo n1 e n2 perché nella somma dei divisori è incluso anche il numero stesso
            {
                Console.WriteLine("I due conti bancari sono finanziariamente sani");
            }
            else
            {
                Console.WriteLine("I due conti bancari non sono finanziariamente sani");
            }
        }

    }
}
