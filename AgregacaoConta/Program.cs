//Main
using AgregacaoConta;

Cliente cl1 = new Cliente("Isa", 3000);

Conta c1 = new Conta(1, 100);
c1.Titular = cl1; //acontece agora a agregação
System.Console.WriteLine("Numero: " + c1.Numero + "\tTitular - Nome: " + c1.Titular.Nome + "\tRg Titular: " + c1.Titular.Rg + "\tSaldo: " + c1.Saldo);

Conta c2 = new Conta(2, 200);
c2.Titular = new Cliente();//construtor padrão
c2.Titular.Nome = "Ju";
c2.Titular.Rg = 2000;
System.Console.WriteLine("Numero: " + c2.Numero + "\tTitular - Nome: " + c2.Titular.Nome + "\tRg Titular: " + c2.Titular.Rg + "\tSaldo: " + c2.Saldo);