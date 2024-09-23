//main
using HerancaFuncionario;

Funcionario f = new Funcionario(1, "Kamily", 10000);
f.Mostrar();
Console.WriteLine($"Bonificação: {f.Bonificacao():c}");

Secretario s = new Secretario(2, "Juliana", 12000);
s.Mostrar();
Console.WriteLine($"Bonificação: {s.Bonificacao():c}");

Gerente g = new Gerente(3, "Isabella", 15000);
g.Mostrar();
Console.WriteLine($"Bonificação: {g.Bonificacao():c}");

Diretor d = new Diretor(4, "Isabelle", 20000);
d.Mostrar();
Console.WriteLine($"Bonificação: {d.Bonificacao():c}");