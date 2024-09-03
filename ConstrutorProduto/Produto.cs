using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set;}
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        //ctor coloca o construtor automatico
        //criar 3 contrutores
        //criar o método MostrarAtributos()
        public Produto()
        {
            //Construtor padrão, não possui nada dentro
        }
        public Produto(int Codigo)
        {
            this.Codigo = Codigo;
        }
        public Produto(int Codigo, string Nome)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
        }
        public Produto(int Codigo, string Nome, decimal Preco)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Preco = Preco;
        }
        public Produto(int Codigo, string Nome, decimal Preco, int Quantidade)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tQuantidade: {Quantidade} \tPreço: {Preco:c}");
        }
    }
}