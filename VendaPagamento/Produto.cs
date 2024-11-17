using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaPagamento
{
    public class Produto
    {
        private long codigo;
        private string nome;
        private double preco;
        private int estoque;

        public static List<Produto> produtos = new List<Produto>();

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
        public void MostrarAtributos()
        {
            Console.WriteLine($"\tCódigo do produto: {Codigo} \tNome do produto: {Nome} \tPreço do produto: {Preco:c}");
        }

        }
    }