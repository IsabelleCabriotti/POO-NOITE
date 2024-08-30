using ArrayFuncionario;

//criar um vetor de 3 elementos
//Cadastrar/Digitar
//Calcule o total de salarios de todos os funcionarios
//Pesquise se há algum funcionario com 100 de salario, informe se encontrou ou não

Funcionario[] vetSalario = new Funcionario[2];
double somaSalarios = 0;
bool salarioEncontrado = false;

for (int i = 0; i < vetSalario.Length; i++)
{
    vetSalario[i] = new Funcionario();
    System.Console.WriteLine("Cadastre o código: ");
    vetSalario[i].codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Cadastre o nome: ");
    vetSalario[i].nome = Console.ReadLine();
    System.Console.WriteLine("Cadastre o salario: ");
    vetSalario[i].salario = Convert.ToDouble(Console.ReadLine());
    somaSalarios += vetSalario[i].salario;
}
foreach(Funcionario f in vetSalario)
{
    if (f.salario == 100)
    {
        System.Console.WriteLine($"O funcionario {f.nome} recebe R$100.00 de salário");
        salarioEncontrado = true;
    }
    if (!salarioEncontrado)
    {
        System.Console.WriteLine("Nenhum funcionario recebe R$100.00 de salário");
    }
}
System.Console.WriteLine($"Soma dos salarios: {somaSalarios}");
foreach(Funcionario f in vetSalario)
{
    f.MostrarAtributos();
}
