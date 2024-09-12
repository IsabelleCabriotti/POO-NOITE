using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaVetor
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Rg { get; set; }

        public Cliente(string nome, int rg)
        {
            Nome = nome;
            Rg = rg;
        }
        public Cliente()
        {
            
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Nome: " + Nome + "\tRG: " + Rg);
        }
    }
}