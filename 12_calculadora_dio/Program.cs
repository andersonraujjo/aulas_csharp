



Console.Write("Digite um numero: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a operação a ser executada: \n");
Console.Write("1 - Adição\n");
Console.Write("2 - Subtração\n");
Console.Write("3 - Multiplicação\n");
Console.Write("4 - Divisão\n");

string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
    Console.WriteLine($"A soma do número {numero1} e {numero2} é igual a {numero1+numero2}.");
    break;

    case "2":
    Console.WriteLine($"A subtração do número {numero1} com {numero2} é igual a {numero1-numero2}.");
    break;

    case "3":
    Console.WriteLine($"A multiplicação do número {numero1} por {numero2} é igual a {numero1*numero2}.");
    break;

    case "4":
    Console.WriteLine($"A divisão do número {numero1} por {numero2} é igual a {numero1/numero2}.");
    break;

    default:
    Console.WriteLine("Opção inválida");
    break;
}



















// using _12_calculadora_dio.Models;


// Calculadora calculadora1 = new Calculadora(); 
// //instanciando a classe, ou seja, a transformando em um objeto 'real'

// calculadora1.Somar(5,9);
// //chama a var que acaba de ser criada, aciona o método somar e passa o argumento
// //o print retorna la do metodo dentro da classe

// calculadora1.Subtrair(45,77);

// calculadora1.Dividir(15,2);

// calculadora1.Multiplicar(8,9);

// calculadora1.Potencia(3,3);

// calculadora1.Raiz(15);