namespace _20_classe_pessoa.Models;


public class Curso
{
    public string Nome {get;set;}
    public List<Pessoa> Alunos {get;set;}

    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }


}