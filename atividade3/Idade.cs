using System;
using System.Collections.Generic;
using System.Text;

namespace atividade3
{
    class Idade
    {
        public string Nome { get; set; }
        public int Idd { get; set; }
        public void Nomes(string ordem)
        {
            Console.Write($"Qual o nome da {ordem} pessoa:");
            Nome = Console.ReadLine();
        }
        public void Idades(string ordem)
        {
            Console.Write($"Qual a idade da {ordem} pessoa:");
            Idd = int.Parse(Console.ReadLine());
        }
    }
}
