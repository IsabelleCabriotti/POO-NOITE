using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoSRP
{
    public class ValidadorUsuarios
    {
        public bool ValidarUsuario(Conta conta, string nome)
        {
            return conta.Titular == nome;
        }
    }
}