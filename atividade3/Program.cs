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
            Console.ReadKey();
            if(P1.Idd > P2.Idd)
                Console.WriteLine("O maior é o primeiro");
            else
                Console.WriteLine("O maior é o segundo");
        }
    }
}
