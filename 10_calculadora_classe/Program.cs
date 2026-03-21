using _10_calculadora_classe.Models;

Calculadora calculo = new Calculadora();
Console.WriteLine($"Soma: {calculo.Somar(5,6)}");
Console.WriteLine($"Subtração: {calculo.Subtrair(7,2)}");
Console.WriteLine($"Divisão: {calculo.Dividir(10,0)}");
Console.WriteLine($"Multiplicação: {calculo.Multiplicar(15,3)}");
