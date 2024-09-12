//Main
using AgregacaoContaVetor;

Cliente cl1 = new Cliente("Isa", 111);
Cliente cl2 = new Cliente("Ju", 222);
Cliente cl3 = new Cliente("Ka", 333);

Conta c1 = new Conta(1, 10000);
c1.Titular = new List<Cliente>();
c1.Titular.Add(cl1);
c1.Titular.Add(cl2);
c1.Titular.Add(cl3);

Console.WriteLine("......Apresentação da Conta......");
c1.MostrarAtributos();
foreach (Cliente c in c1.Titular)
    c.MostrarAtributos();