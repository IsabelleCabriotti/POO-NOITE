using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaVetor
{
    public class Conta
    {
        public int Numero { get; set; }
        //relacionamento entre classes, por meio do atributo titular
        public List<Cliente> Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Numero: " + Numero + "\tSaldo: " + Saldo);
        }
    }
}