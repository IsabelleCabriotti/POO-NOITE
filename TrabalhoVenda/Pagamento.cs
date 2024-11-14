using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class Pagamento
    {
        protected string Data;
        protected double Total;

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}