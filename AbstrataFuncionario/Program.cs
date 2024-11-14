//main
using AbstrataFuncionario;

Assalariado a1 = new Assalariado(1, "Leo", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);

Comissionado c1 = new Comissionado(3, "Ana", 1000, 0.20);
Comissionado c2 = new Comissionado(4, "Bel", 1000, 0.20);

Departamento d1 = new Departamento(1, "DEV");
d1.VetF = new List<Funcionario>();
d1.Admissao(a1);
d1.Admissao(c1);
d1.Listar();
d1.CalcularDependente();
System.Console.WriteLine($"Total {d1.CalcularFolha(30):c}");

Departamento d2 = new Departamento(2, "Redes");
d2.VetF = new List<Funcionario>();
d2.Admissao(a2);
d2.Admissao(c2);
d2.Listar();
d2.Demissao(2);
d2.Listar();
d2.CalcularDependente();
System.Console.WriteLine($"Total {d2.CalcularFolha(30):c}");

a1.AdicionarDependente(new Dependente(1, "Eduardo", 5));
a1.AdicionarDependente(new Dependente(2, "Camila", 10));
c2.AdicionarDependente(new Dependente(3, "Esposa", 45));

c2.RemoverDependente("Esposa");
a1.ListarDependente();

