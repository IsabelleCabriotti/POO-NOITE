using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class Produto
    {
        private long Codigo;
        private string Nome;
        private double Preco;
        private int Estoque;

        public long Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }
        public Produto(long codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
    }
}