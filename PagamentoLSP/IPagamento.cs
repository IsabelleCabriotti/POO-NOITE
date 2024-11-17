using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagamentoLSP
{
    public interface IPagamento
    {
        public void ProcessarPagamento(decimal valor);
    }
}