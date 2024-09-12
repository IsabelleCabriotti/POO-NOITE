using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        public int Quantidade { get; set; }
        public ItemNotaFiscal(int quantidade)
        {
            Quantidade = quantidade;
        }
        ~ItemNotaFiscal(){ //destrutor da classe
            System.Console.WriteLine("Destruir item nota fiscal");
        }
    }
}