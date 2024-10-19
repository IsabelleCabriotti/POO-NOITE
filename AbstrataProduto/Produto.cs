using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataProduto
{
    public abstract class Produto
    {
        public int Codigo { get; set; }
        public double Preco { get; set; }
        public Produto(int codigo, double preco)
        {
            Codigo = codigo;
            Preco = preco;
        }
        public abstract void AtualizarPreco(double preco);
    }
}