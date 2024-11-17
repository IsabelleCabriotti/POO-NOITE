//main
using PagamentoLSP;

class Program
{
    static void Main(string[] args)
    {
        IPagamento p1 = new CartaoCredito();
        IPagamento p2 = new PayPal();
        IPagamento p3 = new Especie();

        p1.ProcessarPagamento(150.50m);
        p2.ProcessarPagamento(200.20m);
        p3.ProcessarPagamento(300.30m);
    }
}