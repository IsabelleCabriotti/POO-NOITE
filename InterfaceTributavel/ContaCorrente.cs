using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class ContaCorrente : ITributavel
    {
        public double Saldo { get; private set; }
        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }
        public double CalcularTributos()
        {
            Console.WriteLine($"Valor do tributo contido na conta corrente: {Saldo * 0.05}");
            return Saldo * 0.05;
        }
    }
}