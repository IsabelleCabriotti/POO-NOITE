//main
using ComposicaoBanco;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\t......Banco......");
        Banco banco = new Banco();
        banco.IniciarBanco();

        Console.WriteLine("\t......Abertura das contas......");
        banco.AbrirContaCorrente(30.00, 500.00);
        banco.AbrirPoupanca(1000.00);

        Console.WriteLine("\t......Conta Corrente......");
        ContaCorrente cc = new ContaCorrente(30.00, 500.00);
        cc.Depositar(30.00);
        cc.Sacar(600.00);
        cc.GerarExtrato();

        Console.WriteLine("\t......Conta Poupança......");
        Poupanca poup = new Poupanca(1000.00);
        poup.Depositar(1000.00);
        poup.Sacar(20.00);
        poup.GerarRendimento(5.0);

        Console.WriteLine("\t......Falência......");
        banco.DeclararFalencia();
    }
}
