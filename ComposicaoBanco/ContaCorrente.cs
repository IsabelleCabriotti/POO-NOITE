using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private double Saldo { get; set; }
        private double ChequeEspecial { get; set; }

        public ContaCorrente(double saldoInicial, double chequeEspecial)
        {
            this.Saldo = saldoInicial;
            this.ChequeEspecial = chequeEspecial;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Deposito de {valor:c} realizado com sucesso!");
        }
        public void Sacar(double valor)
        {
            if (valor <= Saldo + ChequeEspecial)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:c} realizado com sucesso!");
                return;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque!");
                return;
            }
        }
        public void GerarExtrato()
        {
            Console.WriteLine($"Saldo atual: {Saldo:c}");
        }
    }
}