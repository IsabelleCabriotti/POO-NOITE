//main
using AbstrataProduto;

Disco d = new Disco(1, 21, "The Weeknd", "Umusic");
d.AtualizarPreco(100);
System.Console.WriteLine(d.Preco);

Livro l = new Livro(2, 300, "Box Duna", 222222);
l.AtualizarPreco(200);
System.Console.WriteLine(l.Preco);
