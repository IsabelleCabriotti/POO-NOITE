using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Diretor : Funcionario, IAutenticavel
    {
        public bool Autentica(int senha)
        {
            if (Senha == senha)
            {
                System.Console.WriteLine("Diretor Autenticado!");
                return true;
            }
            return false;
        }
    }
}