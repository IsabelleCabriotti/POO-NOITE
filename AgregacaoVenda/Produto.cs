using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        private static int codigoInicial = 500;

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Codigo = codigoInicial++;

            if (preco > 0)
            Preco = preco;
            else
                Console.WriteLine("O preço do produto deve ser maior que zero. Insira novamente!");

        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"\tCódigo do produto: {Codigo} \tNome do produto: {Nome} \tPreço do produto: {Preco:c}");
        }
    }
}