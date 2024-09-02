using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        private string nome; //fazer encapsulamento
        
        private double preco;

        private int quantidade;

        //declarar metodos do encapsulamento
        public int Quantidade
        {
            get { return quantidade; }
            set{
                if(value > 0)
                    quantidade = value;
                else
                    System.Console.WriteLine("Quantidade invalida");
                }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public string Nome
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
        }
        public void MostrarProduto()
        {
            Console.WriteLine("Nome: " + nome + "\tQuantidade " + quantidade + "\tPreço: " + preco);
        }
        public void AdicionarProduto(int qtd)
        {
            quantidade += qtd;
        }
        public void RemoverProduto(int qtd)
        {
            quantidade += qtd;
        }
        public double ValorTotalEstoque()
        {
            return preco * quantidade;
        }
    }
}