using ArrayConta;

//declarar o vetor de objetos
Conta[] vetContas = new Conta[3];

//manipular o vetor, nó de repetição
for (int i = 0; i < vetContas.Length; i++)
{
    vetContas[i] = new Conta();
    System.Console.WriteLine("Cadastre o número: ");
    vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Cadastre o titular: ");
    vetContas[i].titular = Console.ReadLine();
    System.Console.Write("Cadastre o saldo: ");
    vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
}

foreach (Conta c in vetContas)
{
    c.MostrarAtributos();
}