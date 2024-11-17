using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoSRP
{
    public class GeradorRelatorios
    {
        public string GerarRelatorio(Conta conta)
        {
            return $"Titular: {conta.Titular}\tSaldo: {conta.Saldo:C}";
        }
    }
}