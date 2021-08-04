using System;
using System.Collections.Generic;
using System.Text;

namespace atividade1
{
    class Produto
    {
        private string Nome { get; set; }
        private double Preco { get; set; }
        private int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public void AdicionarProduto(int qtd)
        {
            Quantidade += qtd;
        }
        public void RemoverProduto(int qtd)
        {
            Quantidade -= qtd;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return $"Dados do produto: {Nome}, $ {Preco}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque()}";
        }
    }
}
