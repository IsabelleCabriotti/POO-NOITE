using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaPagamento
{
    public class ItemVenda
    {
        private int quantidade;
        private double preco;
        private double subTotal;
        private Produto produto;
        public int Quantidade
        {
            get { return quantidade;}
            set { quantidade = value; }
        }
        public double Preco
        {
            get { return preco;}
            set { preco = value; }
        }
        public double SubTotal
        {
            get { return subTotal;}
            set { subTotal = value; }
        }
        public Produto Produto
        {
            get { return produto;}
            set { produto = value; }
        }
        public ItemVenda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = produto.Preco;
            SubTotal = Preco * Quantidade;
        }
    }
}