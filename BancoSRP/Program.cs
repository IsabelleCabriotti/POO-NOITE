//main
using BancoSRP;

class Program
{
    static void Main(string[] args)
    {
        Conta c1 = new Conta("Amanda Santos");

        c1.Deposito(200);
        c1.Sacar(50);

        ValidadorUsuarios v1 = new ValidadorUsuarios();
        bool usuarioValido = v1.ValidarUsuario(c1, "Amanda Santos");
        Console.WriteLine($"O usúario é válido? {usuarioValido}");

        GeradorRelatorios g1 = new GeradorRelatorios();
        string relatorio = g1.GerarRelatorio(c1);
        Console.WriteLine($"Relatorio da conta: ");
        Console.WriteLine(relatorio);
    }
}