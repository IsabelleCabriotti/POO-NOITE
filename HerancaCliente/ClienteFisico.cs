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
        public ClienteFisico() : base()//chama o construtor
        {
            
        }
        public void Mostrar()
        {
            base.Mostrar();//apresenta o codigo e nome pois chama o metodo da classe base
            System.Console.WriteLine("Rg: " + Rg + "\tCpf: " + Cpf);
        }
    }
}