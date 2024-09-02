using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        //declaração dos atributos
        private int codigo;
        private string nome;
        private double salario;
        //declaração dos métodos
        /*metodos de encapsulamento get e set
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return this.codigo;
        }*/
        public int Codigo
        {
            set{
                this.codigo = value; //set, tendo atribuição
            }
            get{
                return codigo; //get sem atribuição, apenas return
            }
        }
        public string Nome
        {
            set{
                this.nome = value;
            }
            get{
                return nome;
            }
        }
        public double Salario
        {
            set{
                this.salario = value;
            }
            get{
                return salario;
            }
        }
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