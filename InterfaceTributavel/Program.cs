//main
using InterfaceTributavel;

ContaCorrente c1 = new ContaCorrente(200.0);
SeguroVida s1 = new SeguroVida();

TotalizadorTributos t1 = new TotalizadorTributos();
t1.Adicionar(c1);
t1.Adicionar(s1);

Console.WriteLine("Total de imposto: " + t1.Total);