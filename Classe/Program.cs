//função Main()
using Classe;

//instanciar objetos
Conta conta1;//declaração da variavel
conta1 = new Conta(); //instancia de objeto do new para frente
conta1.numero = 1;
conta1.titular = "Fatec";
conta1.saldo = 100;
Console.WriteLine("Numero: "+ conta1.numero + "\tTitular: " + conta1.titular + "\tSaldo: " + conta1.saldo);

Conta conta2 = new Conta();
conta2.numero = 2;
conta2.titular = "Fateca";
conta2.saldo = 150;
Console.WriteLine("Numero: "+ conta2.numero + "\tTitular: " + conta2.titular + "\tSaldo: " + conta2.saldo);
conta2.Transferencia(50, conta1);
Console.WriteLine("Numero: "+ conta2.numero + "\tTitular: " + conta2.titular + "\tSaldo: " + conta2.saldo);
Console.WriteLine("Numero: "+ conta1.numero + "\tTitular: " + conta1.titular + "\tSaldo: " + conta1.saldo);

/*Conta conta3 = new Conta();
Console.WriteLine("Cadastre o número da conta: ");
conta3.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Cadastre o titular da conta: ");
conta3.titular = Console.ReadLine();
Console.Write("Cadastre o saldo da conta: ");
conta3.saldo = Convert.ToInt32(Console.ReadLine());*/