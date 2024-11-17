using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagamentoLSP
{
    public class CartaoCredito : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Processado pagamento de {valor:C} via Cartão de crédito.");
        }
    }
}