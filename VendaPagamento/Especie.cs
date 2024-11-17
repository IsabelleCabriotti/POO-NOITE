using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaPagamento
{
    public class Especie : Pagamento
    {
        private double quantia;
        private double troco;

        public double Quantia
        {
            get { return quantia; }
            set { quantia = value; }
        }
        public double Troco
        {
            get { return troco; }
            set { troco = value; }
        }
        public Especie(DateTime data, double total, double quantia, double troco) : base(data, total)
        {
            Quantia = quantia;
            Troco = troco;
        }
    }
}