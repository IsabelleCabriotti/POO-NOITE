using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class Venda
    {
        private string Data;

        private double Total;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public Venda(string data, double total)
        {
            Data = data;
            Total = total;
        }
    }
}