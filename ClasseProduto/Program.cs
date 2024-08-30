using ClasseProduto;
Produto p1 = new Produto(); //instancia, declaração da variavel

Console.WriteLine("Digite o nome do produto: ");
p1.nome = (Console.ReadLine());
Console.WriteLine("Digite o preço do produto: ");
p1.preco = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Digite a quantidade do produto: ");
p1.quantidade = Convert.ToInt32(Console.ReadLine());
p1.AdicionarProduto(5);
p1.MostrarProduto();


Produto p2 = new Produto(); //instancia, declaração da variavel

Console.WriteLine("Digite o nome do produto: ");
p2.nome = (Console.ReadLine());
Console.WriteLine("Digite o preço do produto: ");
p2.preco = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Digite a quantidade do produto: ");
p2.quantidade = Convert.ToInt32(Console.ReadLine());
p2.RemoverProduto(2);
p2.MostrarProduto();
System.Console.WriteLine($"Valor total: {p2.ValorTotalEstoque():c}");