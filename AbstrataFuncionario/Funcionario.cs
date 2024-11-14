using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public List<Dependente> Dependente { get; set; }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Dependente = new List<Dependente>();
        }
        public abstract double CalcularSalario(int diasUteis);
        public virtual void MostrarAtributos()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalario: " + Salario);
        }
        public int TotalDependentes()
        {
            return Dependente.Count;
        }
        public void AdicionarDependente(Dependente dependente)
        {
            if (dependente.VerificarMaiorIdade() == false)
                Dependente.Add(dependente);
            else
                Console.WriteLine("O dependente não pode ser adicionado!");
        }
        public void RemoverDependente(string nome)
        {
            Dependente.RemoveAll(d => d.Nome == nome);
        }
        public void ListarDependente()
        {
            Console.WriteLine($"Dependentes do funcionario {Nome}: ");
            foreach (var dependente in Dependente)
            {
                Console.WriteLine($"Nome do dependente: {dependente.Nome}", $"\tIdade do dependente: {dependente.Idade}");
            }
        }
    }
}