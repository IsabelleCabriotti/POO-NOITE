//Main
using EncapsulamentoAluno;

Aluno a1 = new Aluno();
a1.Matricula = 2; //set
a1.P1 = 6; //set
a1.P2 = 8; //set
a1.CalcularMedia();
System.Console.WriteLine("Media: " + a1.Media); //get
a1.Mostrar();
