using System;

namespace atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            Idade P1 = new Idade();
            Idade P2 = new Idade();
            P1.Nomes("primeira");
            P1.Idades("primeira");
            P2.Nomes("segunda");
            P2.Idades("segunda");
            if(P1.Idd > P2.Idd)
                Console.WriteLine($"A pessoa mais velha é {P1.Nome}");
            else
                Console.WriteLine($"A pessoa mais velha é {P2.Nome}");
            Console.ReadKey();
        }
    }
}
