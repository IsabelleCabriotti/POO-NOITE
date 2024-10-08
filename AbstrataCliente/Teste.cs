using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class Teste
    {
        //representação do relacionamento de dependencia, por meio de um parâmetro que é o objeto de outra classe
        public void AvaliarIdade(Cliente cliente)
        {
            cliente.VerificarIdade();
        }
    }
}