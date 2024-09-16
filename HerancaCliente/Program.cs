//main
using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "João";
c.Mostrar();

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Ana";
cf.Cpf = 45704565883;
cf.Rg = 551754254;
cf.Mostrar();

Cliente c2 = new Cliente(3, "Leo");
c2.Mostrar();

ClienteFisico cf2 = new ClienteFisico(4, "Lia", 13830470819, 551754296);
cf2.Mostrar();