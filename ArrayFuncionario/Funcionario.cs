using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    public class Funcionario
    {
        //declaração dos atributos
        public int codigo;
        public string nome;
        public double salario;
        //declaração dos métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tSalário R$ " + salario);
        }
        //criar um metodo para aplicar uma porcentagem de aumento ao salario
        public void AumentoSalario()
        {
            Console.WriteLine("Novo Salário R$ " + (salario * 0.5 + salario));
        }
    }
}