using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class SeguroVida : ITributavel
    {
        public double CalcularTributos()
        {
            Console.WriteLine($"Valor do tributo contido no seguro de vida: 75");
            return 75.0;
        }
    }
}