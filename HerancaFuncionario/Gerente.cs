using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Gerente : Funcionario
    {
        public Gerente(int codigo, string nome, double salario) : base (codigo, nome, salario)
        {}
        public override double Bonificacao()
        {
            return Salario * 15 / 100;
        }
    }
}