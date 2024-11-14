using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class Cartao : Pagamento
    {
        private string DadosTransacao;
        private int ResultadoTransacao;

        public Cartao(string data, double total, string dadostransacao, int resultadotransacao) : base(dadostransacao, resultadotransacao)
        {
            DadosTransacao = dadostransacao;
            ResultadoTransacao = resultadotransacao;
        }
        public Cartao() : base()
        {
            
        }
    }
}