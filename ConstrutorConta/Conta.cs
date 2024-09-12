using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        //declaração dos atributos
        private int numero;
        private string titular;
        private double saldo;
        private  static int contador;

        public static int Contador
        {
            get { return contador; }
        }

        //declaração dos metodos
        public Conta()
        {
            contador ++;
            //Construtor padrão, não possui nada dentro
        }
        public Conta(int numero)
        {
            this.numero = numero;
            contador ++;
        }
        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            contador ++;
        }
        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
            contador ++;
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Número: {numero} \tTitular: {titular} \tSaldo {saldo:c}");
        }
    }
}