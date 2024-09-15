using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        private const double Comissao = 2;
        private double comissaoRec;

        public void CalcularComissao(double precoT)
        {
            comissaoRec = precoT * (Comissao / 100);
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Comissão total do vendedor: {comissaoRec:c}");
        }
    }
}