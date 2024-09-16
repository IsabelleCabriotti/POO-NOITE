using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{//            classe derivada : classe base
    public class ClienteFisico : Cliente
    {
        private long cpf;
        private long rg;
        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public long Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public ClienteFisico(int codigo, string nome, long cpf, long rg) : base(codigo, nome) //acessa a classe base = Cliente/pai
        {
            Cpf = cpf;
            Rg = rg;
        }
        public ClienteFisico() : base()
        {
            
        }
        /*public void Mostrar()
        {

        }*/
    }
}