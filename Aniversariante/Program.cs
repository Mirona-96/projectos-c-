class Pessoa
{
public int id;

public string nome;

public int idade;

public int qtdAniversario;

    public Pessoa() { 
    }

    public Pessoa (int id, string nome, int idade)
    {
        this.id = id;
        this.nome = nome;
        this.idade = idade;
        qtdAniversario = 0;
    }

public void CompletarAniversario()
    {
        idade++;
        qtdAniversario++;
    }

    public void imprimir ()
    {
        Console.WriteLine ("\nnome: " +nome 
            + "\nidade: " +idade 
            + "\naniversarios feitos: " + qtdAniversario);
    }
}