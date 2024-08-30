using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        private string nome;
        
        private double preco;

        private int quantidade;

        public void MostrarProduto()
        {
            Console.WriteLine("Nome: " + nome + "\tQuantidade " + quantidade + "\tPreço: " + preco);
        }

        public void AdicionarProduto(int qtd)
        {
            quantidade = quantidade + qtd;
        }
        public void RemoverProduto(int qtd)
        {
            quantidade = quantidade - qtd;
        }
        public double ValorTotalEstoque()
        {
            return preco * quantidade;
        }
    }
}