using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        private double verba;
        public double Verba
        {
            get { return verba; }
            set 
            { 
                if (value >= 0)
                    verba  = value;
                else
                    Console.WriteLine("A verba não pode ser negativa!");
            }
        }
        public Comprador(double verba)
        {
            this.Verba = verba;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"A verba total do comprador é: {verba:c}");
        }
    }
}