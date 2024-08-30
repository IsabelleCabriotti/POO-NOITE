// função main()

using ClasseFuncionario;
//instanciar o objeto para conseguir cadastrar algo
Funcionario f1 = new Funcionario(); //instancia, declaração da variavel

Console.WriteLine("Digite o código: ");
f1.codigo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o nome: ");
f1.nome = (Console.ReadLine());
Console.WriteLine("Digite o salário: ");
f1.salario = Convert.ToDouble(Console.ReadLine());
f1.MostrarAtributos();//enviando uma mensagem
f1.AumentoSalario();

Funcionario f2 = new Funcionario(); //instancia, declaração da variavel

Console.WriteLine("Digite o código: ");
f2.codigo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o nome: ");
f2.nome = (Console.ReadLine());
Console.WriteLine("Digite o salário: ");
f2.salario = Convert.ToDouble(Console.ReadLine());
f2.MostrarAtributos();//enviando uma mensagem
f2.AumentoSalario();

double somaSalarios = f1.salario + f2.salario; //soma do estado do objeto salario