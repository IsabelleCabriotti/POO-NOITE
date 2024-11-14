using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class Especie : Pagamento
    {
        private double Quantia;
        private double Troco;

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
        public Especie(string data, double total, double quantia, double troco) : base(quantia, troco)
        {
            Quantia = quantia;
            Troco = troco;
        }
        public Especie() : base()
        {
            
        }
    }
}