using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        private Comprador comprador;
        private Vendedor vendedor;
        private List<Produto> produtosVend;

        public Venda(Comprador comprador, Vendedor vendedor)
        {
            this.comprador = comprador;
            this.vendedor = vendedor;
            produtosVend = new List<Produto>();
        }
        public void AddProduto(Produto produto)
        {
            if (produto.Preco <= 0)
            {
                Console.WriteLine("Podutos não adicionados, preço deve ser maior que zero!");
                return;
            }
            produtosVend.Add(produto);
        }
        public void finalVenda()
        {
            double precoT = 0;
            foreach (Produto p in produtosVend)
            {
                precoT += p.Preco;
            }
            Console.WriteLine($"Preço total da venda: {precoT:c}");

            if (precoT > comprador.Verba)
            {
                Console.WriteLine("Compra não finalizada, comprador sem saldo suficiente!");
                return;
            }
            comprador.Verba -= precoT;
            vendedor.CalcularComissao(precoT);
            vendedor.MostrarAtributos();
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("\tProdutos selecionados: ");
            foreach (Produto produto in produtosVend)
            {
                produto.MostrarAtributos();
            }
        }
    }
}