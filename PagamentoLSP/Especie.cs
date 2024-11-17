using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagamentoLSP
{
    public class Especie : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Processado pagamento de {valor:C} em Espécie.");
        }
    }
}