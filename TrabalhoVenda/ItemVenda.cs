using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class ItemVenda
    {
        private int Quantidade;
        private double Preco;
        private double SubTotal;
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
        private double SubTotal
        {
            get { return subtotal;}
            set { subtotal = value; }
        }
        public ItemVenda(int quantidade, double preco, double subtotal)
        {
            Quantidade = quantidade;
            Preco = preco;
            SubTotal = subtotal;
        }
        public void 
    }
}