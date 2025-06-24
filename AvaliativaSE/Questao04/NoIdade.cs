using System;

public class NoIdade
{
    // O dado armazenado, neste caso, a idade de um aluno.
    public int Idade { get; set; }
    
    public NoIdade Proximo { get; set; }

    /// <summary>
    /// Construtor que cria um novo nó com a idade especificada.
    /// </summary>
    /// <param name="idade">A idade a ser armazenada no nó.</param>
    public NoIdade(int idade)
    {
        this.Idade = idade;
        this.Proximo = null; // Um novo nó, por padrão, não aponta para ninguém.
    }
}