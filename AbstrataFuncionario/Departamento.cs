using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF { get; set; }
        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            VetF = new List<Funcionario>();
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome);
        }
        public void Admissao(Funcionario f)
        {
            VetF.Add(f);
        }
        public void Listar()
        {
            MostrarAtributos();
            foreach(Funcionario f in VetF)
                f.MostrarAtributos();
        }
        public void Demissao(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                    VetF.Remove(f);
            }
        }
        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }
        public void CalcularDependente()
        {
            MostrarAtributos();
            foreach(Funcionario f in VetF)
            {
                Console.WriteLine($"{f.Nome}: {f.TotalDependentes()}");
            }
        }
    }
}