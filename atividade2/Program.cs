using System;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda a = new ConversorDeMoeda();
            a.Pcotacao();
            a.Pcomprar();
            Console.WriteLine(a.ToString());
        }
    }
}
