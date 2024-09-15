using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        public long Matricula { get; private set; }
        public string Nome { get; set; }
        private static long contador = 1570482313000;
        public Aluno()
        {
            contador++;
        }
        public Aluno(string Nome)
        {
            this.Nome = Nome;
            Matricula = contador;
            contador++;
        }
        public Aluno(long Matricula)
        {
            this.Matricula = contador;
            contador++;
        }
        public Aluno(long Matricula, string Nome)
        {
            this.Matricula = Matricula;
            this.Nome = Nome;
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Nome: {Nome} \tMatrícula: {Matricula}");
        }
    }
}