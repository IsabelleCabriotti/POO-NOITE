// main
using AbstrataCliente;
//gera erro por não poder instanciar
//Cliente c = new Cliente(1, "Ana");

ClienteFisico cf = new ClienteFisico(2, "Bia", 30, 222);
cf.MostrarAtributos();

ClienteJuridico cj = new ClienteJuridico(3, "Leo", 50, 3333);
cj.MostrarAtributos();

Teste t = new Teste();
t.AvaliarIdade(cj);
