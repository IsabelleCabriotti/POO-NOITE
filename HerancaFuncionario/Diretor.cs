using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Diretor : Funcionario
    {
        public Diretor(int codigo, string nome, double salario) : base (codigo, nome, salario)
        {}
        public virtual double Bonificacao()
        {       //retorno de 10%
            return base.Bonificacao() + 1000;
        }
    }
}