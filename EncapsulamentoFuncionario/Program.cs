//main
using EncapsulamentoFuncionario;

Funcionario f1 = new Funcionario();
f1.Codigo = 1;//set sendo executado por causa da atribuição, que so acontece em set
f1.Nome = "Isabelle";
f1.Salario = 30000;
System.Console.WriteLine($"Codigo: {f1.Codigo}\nNome: {f1.Nome}\nSalario: {f1.Salario}");//get sendo executado, sem atribuição
