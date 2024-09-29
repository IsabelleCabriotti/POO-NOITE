using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class GerenciarBonificacao
    {
        private double totalBonificacao;

        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.Bonificacao();
        }
        public void TotalizadorBonificacao(Secretario secretario)
        {
            this.totalBonificacao += secretario.Bonificacao();
        }
        public void TotalizadorBonificacao(Gerente gerente)
        {
            this.totalBonificacao += gerente.Bonificacao();
        }
        public void TotalizadorBonificacao(Diretor diretor)
        {
            this.totalBonificacao += diretor.Bonificacao();
        }
        public double GettotalBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}