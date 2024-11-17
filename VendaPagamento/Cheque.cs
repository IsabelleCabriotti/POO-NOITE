using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaPagamento
{
    public class Cheque : Pagamento
    {
        private long numero;
        private DateTime dtDeposito;
        private int situacao;

        public long Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public DateTime DtDeposito
        {
            get { return dtDeposito; }
            set { dtDeposito = value;}
        }
        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
        public Cheque(DateTime data, double total, long numero, DateTime dtDeposito, int situacao) : base(data, total)
        {
            Numero = numero;
            DtDeposito = dtDeposito;
            Situacao = situacao;
        }
    }
}