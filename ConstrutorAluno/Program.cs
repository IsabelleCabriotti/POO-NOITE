/*crias a classe Aluno, com os atributos matricula, nome
        Utilizar o atributo static para crias as matriculas de forma automática a casa instância seguindo o padrão Fatec 1570482313000
        O atributo matricula não será static
        Utilize se quiser o atributo contador para auxiliar a contagem e registro da matricula
        Criar o método mostrar e chamar após cada instância
        Instancie pelo menos 2 objetos de construtores diferentes*/
using ConstrutorAluno;
internal class Program
{
    public static void Main(string[] args)
    {
        Aluno al1 = new Aluno("Mariana Silva");
        al1.MostrarAtributos();
        Aluno al2 = new Aluno("Isabelle Cabriotti");
        al2.MostrarAtributos();
    }
}
