namespace _10_calculadora_classe.Models;

public class Calculadora
{
    public double Somar(double a, double b)
    {
        return a + b;
    }


    public double Subtrair(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar (double a, double b)
    {
        return a * b;
    }

    public double Dividir (double a, double b)
    {
        if (b == 0)
        {
        Console.WriteLine("Divisão por 0 não será possível.");
        return 0;
        }
        else return a / b;
    }

}

