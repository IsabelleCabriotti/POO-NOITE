//main
using ConstrutorProduto;

Produto p1 = new Produto();
p1.MostrarAtributos();
//conta1.saldo = 1;
Produto p2 = new Produto(20);
p2.MostrarAtributos();

Produto p3 = new Produto(30, "Ju");
p3.MostrarAtributos();

Produto p4 = new Produto(40, "Isa", 400, 20);
p4.MostrarAtributos();
