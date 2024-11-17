using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class TotalizadorTributos
    {
        public double Total { get; private set; }
        public void Adicionar(ITributavel t)
        {
            Total += t.CalcularTributos();
        }
    }
}