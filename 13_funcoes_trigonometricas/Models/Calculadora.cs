namespace _13_funcoes_trigonometricas.Models;



public class Calculadora
{
    public void Seno(double angulo) //void o proprio método executa a ação, mas não retorna nada.
    {
        double radiano = angulo * Math.PI / 180; //math metodo nativo para operações complexas em c#
        double seno = Math.Sin(radiano);
        Console.WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}"); //math roun corta casas decimais (var,qtd_de_casas)
        
    }

    public void Coseno(double angulo) 
    {
        double radiano = angulo * Math.PI / 180;
        double coseno = Math.Cos(radiano);
        Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno,4)}");
        
    }

    public void Tangente(double angulo) 
    {
        double radiano = angulo * Math.PI / 180; 
        double tangente = Math.Tan(radiano);
        Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente,4)}");
        
    }



    
    public void Potencia(int x, int y)
    {
        double potencia = Math.Pow (x,y); //método nativo de potencia
        Console.WriteLine($"A potência de {x}^{y} é: {potencia}");
    }


}