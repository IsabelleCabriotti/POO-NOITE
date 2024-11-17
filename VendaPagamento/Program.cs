﻿//main
using VendaPagamento;
class Program
{
    static void Main(string[] args)
    {
        Venda venda = new Venda(DateTime.Now);

        Produto p1 = new Produto(1, "Shampoo", 10.0, 100);
        Produto p2 = new Produto(2, "Condicionador", 15.0, 200);
        Produto p3 = new Produto(3, "Condicionador", 5.0, 300);

        Console.WriteLine("\t......Venda......");
        venda.AdicionarItem(new ItemVenda(p1, 30));
        venda.AdicionarItem(new ItemVenda(p2, 20));
        venda.AdicionarItem(new ItemVenda(p3, 20));
        venda.MostrarAtributos();

        venda.RealizarVenda();

        Console.WriteLine("Escolha o método de pagamento:");
            Console.WriteLine("1. Espécie");
            Console.WriteLine("2. Cheque");
            Console.WriteLine("3. Cartão");
            string opcaoPagamento = Console.ReadLine();

            switch (opcaoPagamento)
            {
                case "1":
                    Console.WriteLine("Pagamento realizado em espécie.");
                    Console.Write("Informe o valor pago: ");
                    ValorPago = Convert.ToDouble(Console.ReadLine());

                    if (ValorPago >= TotalComDesconto())
                    {
                        Troco = ValorPago - TotalComDesconto();
                        Console.WriteLine($"Pagamento realizado com sucesso! Troco: {Troco:C}");
                    }
                    else
                    {
                        Console.WriteLine("Valor insuficiente. Pagamento não realizado.");
                    }
                    break;
                case "2":
                    Cheque pagamentoCheque = new Cheque(DateTime.Now, venda.Total, 1234567890, DateTime.Now.AddDays(3), 1);
                    Console.WriteLine("\tDetalhes do pagamento com cheque:");
                    Console.WriteLine($"Número do cheque: {pagamentoCheque.Numero}");
                    Console.WriteLine($"Data de depósito: {pagamentoCheque.DtDeposito.ToShortDateString()}");
                    Console.WriteLine($"Situação: {pagamentoCheque.Situacao}");
                    break;
                case "3":
                    // Pagamento com cartão
                    Console.WriteLine("Pagamento realizado com cartão.");
                    dadosTransacao = DateTime.Now;
                    resultadoTransacao = "Aprovado";
                    Console.WriteLine($"Dados da Transação: {dadosTransacao}");
                    Console.WriteLine($"Resultado da transação: {resultadoTransacao}");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Pagamento não realizado.");
                    break;
            }
        Console.WriteLine("\tVenda e pagamento processados com sucesso!");
    }
}