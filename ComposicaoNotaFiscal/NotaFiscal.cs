using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf {get; set;}
        public string Data {get; set;}
        public List<ItemNotaFiscal> Vetitens { get; set; }
        public NotaFiscal(int numeroNf, string data)
        {
            NumeroNf = numeroNf;
            Data = data;
            //a composição acontece agora, pois os objetos nota fiscal e vetor de itens são instanciados juntos
            Vetitens = new List<ItemNotaFiscal>();
        }
        ~NotaFiscal(){
            Vetitens = null;
            System.Console.WriteLine("Destruir a nota fiscal");
        }
    }
}