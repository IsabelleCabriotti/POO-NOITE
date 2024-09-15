using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        private double Saldo { get; set; }

        public Poupanca(double saldoInicial)
        {
            this.Saldo = saldoInicial;
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Deposito de {valor:c} realizado com sucesso!");
                return;
            }
            else
            {
                Console.WriteLine("Valor do deposito precisa ser maior que zero!");
                return;
            }
        }
        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:c} realizado com sucesso!");
                return;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }
        }
        public void GerarRendimento(double taxa)
        {
            Saldo += Saldo * (taxa / 100);
            Console.WriteLine($"Rendimento gerado com taxa de {taxa}%.");
            Console.WriteLine($"Novo Saldo: {Saldo:c}");
        }
    }
}