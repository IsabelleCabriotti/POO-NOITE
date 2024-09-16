using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente
    {
        protected int codigo; //fica visivel para que a classe ClienteFisico visualize o codigo e nome, com private não é possivel essa visualização
        protected string nome;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public void Mostrar()
        {
            System.Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome);
        }
        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public Cliente()
        {
            
        }
    }
}