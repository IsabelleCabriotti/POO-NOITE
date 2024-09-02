//Main

using EncapsulamentoProduto;

Produto p1 = new Produto();
System.Console.WriteLine("Informe o nome do produto: ");
p1.Nome = Console.ReadLine();//set
System.Console.WriteLine("Informe a quantidade do produto: ");
p1.Quantidade = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Informe o preço do produto: ");
p1.Preco = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Nome:  + {p1.Nome}");//get, pois não te atribuição
