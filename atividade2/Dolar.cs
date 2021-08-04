using System;
using System.Collections.Generic;
using System.Text;

namespace atividade2
{
    class Dolar
    {
        public double Cotacao { get; set; }
        public double Comprar { get; set; }
        public double Pagar { get; set; }

        public void Pergunta()
        {
            Console.Write("Qual a cotação do dolar? ");
            Cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar?");
        }
    }
}
