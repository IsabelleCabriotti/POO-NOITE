//main
using HerancaProduto;

Produto p1 = new Produto();
p1.Codigo = 1;
p1.Nome = "Faca";
p1.Preco = 5.00;
p1.Mostrar();

Perecivel pr1 = new Perecivel();
pr1.Codigo = 3;
pr1.Nome = "Mussarela";
pr1.Preco = 15.00;
pr1.DtValidade = "22/09/2024";
pr1.DtFabricacao = "18/09/2024";
pr1.Lote = 2;
pr1.Mostrar();

Produto p2 = new Produto(2, "Garfo", 5.00);
p2.Mostrar();

Perecivel pr2 = new Perecivel(4, "Mortadela", 15.00, "22/09/2024", "18/09/2024", 3);
pr2.Mostrar();
