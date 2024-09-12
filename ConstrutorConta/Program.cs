//main
using ConstrutorConta;

Conta conta1 = new Conta();
conta1.MostrarAtributos();
//conta1.saldo = 1;
Conta conta2 = new Conta(20);
conta2.MostrarAtributos();

Conta conta3 = new Conta(30, "Ju");
conta3.MostrarAtributos();

Conta conta4 = new Conta(40, "Isa", 400);
conta4.MostrarAtributos();
System.Console.WriteLine("Quantidade de instâncias " + Conta.Contador);