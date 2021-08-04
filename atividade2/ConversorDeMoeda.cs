using System;
using System.Collections.Generic;
using System.Text;

namespace atividade2
{
    class ConversorDeMoeda
    {
        public double Cotacao { get; set; }
        public double Comprar { get; set; }

        public void Pcotacao()
        {
            Console.Write("Qual a cotação do dólar? ");
            Cotacao = double.Parse(Console.ReadLine());
        }
        public void Pcomprar()
        {
            Console.Write("Quantos dólares você vai comprar?");
            Comprar = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Valor a ser pago em reais = {(Cotacao * Comprar)* 1.06 }";
        }
    }

}
