//main
using AgregacaoVenda;
class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new Produto("Notebook", 3000.00);
        Produto p2 = new Produto("Mouse", 70.00);
        Produto p3 = new Produto("Teclado", 150.00);

        Comprador c1 = new Comprador(3100.00);
        Vendedor v1 = new Vendedor();

        Venda vd1 = new Venda(c1, v1);
        Console.WriteLine("\t......Venda 1......");
        vd1.AddProduto(p1);
        vd1.AddProduto(p2);
        vd1.MostrarAtributos();
        vd1.finalVenda();

        c1.MostrarAtributos();

        Venda vd2 = new Venda(c1, v1);
        Console.WriteLine("\t......Venda 2......");
        vd2.AddProduto(p1);
        vd2.AddProduto(p2);
        vd2.AddProduto(p3);
        vd2.MostrarAtributos();
        vd2.finalVenda();

        c1.MostrarAtributos();
    }
}
