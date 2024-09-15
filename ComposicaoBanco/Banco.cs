using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        private List<Poupanca> poup;
        private List<ContaCorrente> cc;

        public Banco()
        {
            poup = new List<Poupanca>();
            cc = new List<ContaCorrente>();
        }
        public void IniciarBanco()
        {
            Console.WriteLine("Banco Iniciado!");
        }
        public void AbrirContaCorrente(double saldoInicial, double chequeEspecial)
        {
            ContaCorrente contaCorrente = new ContaCorrente(saldoInicial, chequeEspecial);
            cc.Add(contaCorrente);
            Console.WriteLine("Conta Corrente aberta com sucesso!");
        }
        public void AbrirPoupanca(double saldoInicial)
        {
            Poupanca poupanca = new Poupanca(saldoInicial);
            poup.Add(poupanca);
            Console.WriteLine("Conta Poupanca aberta com sucesso!");
        }
        public void DeclararFalencia()
        {
            poup.Clear();
            cc.Clear();
            Console.WriteLine("O banco decretou falência!");
        }
    }
}