using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class Cheque : Pagamento
    {
        private long Numero;
        private string DtDeposito;
        private int Situacao;

        public Cheque(string data, double total, long numero, string dtDeposito, int situacao) : base(numero, dtDeposito, situacao)
        {
            Numero = numero;
            DtDeposito = dtDeposito;
            Situacao = situacao;
        }
        public Cheque() : base()
        {
            
        }
    }
}