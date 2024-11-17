using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaPagamento
{
    public class Venda
    {
        public DateTime Data { get; set; }
        public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();
        public Venda(DateTime data)
        {
            Data = data;
        }
        public double Total 
        {
            get
            {
                double total = 0;
                foreach (var item in Itens)
                {
                    total += item.SubTotal;
                }
                return total;
            }
        }
        public void AdicionarItem(ItemVenda item)
        {
            Itens.Add(item);
        }
        public double CalcularDesconto()
        {
            int quantidadeTotal = 0;
            foreach (var item in Itens)
            {
                quantidadeTotal += item.Quantidade;
            }

            if (quantidadeTotal > 50)
            {
                return Total * 0.2;
            }
            return 0;
        }
        public double TotalComDesconto()
        {
            return Total - CalcularDesconto();
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("\tProdutos selecionados: ");
            foreach (var item in Itens)
            {
                item.Produto.MostrarAtributos();
            }
        }
        public void RealizarVenda()
        {
            Console.WriteLine($"Data da venda: {Data}");
            Console.WriteLine($"Total da venda (já com desconto, se houver): {TotalComDesconto():C}");
        }
    }
}