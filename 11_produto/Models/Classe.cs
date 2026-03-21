
namespace _11_produto.Models;

public class Produto
{
    public string nome;
    public double preco;
    public int quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
        nome = nome; preco = preco, quantidade = quantidade;
    }

    public double ValorEmEstoque()
    {
        return preco * quantidade;
    }

}