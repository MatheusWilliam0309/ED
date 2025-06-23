using System;
using System.Security.Cryptography;

public class ListaEncadeada
{
    private No inicio; // O primeiro nó da lista. Se for null, a lista está vazia.

    public ListaEncadeada()
    {
        inicio = null;
    }

    // a) Implemente a operação de inserção de um elemento pelo início.
    public void InserirInicio(Funcionario funcionario)
    {
        No novoNo = new No(funcionario);
        novoNo.Proximo = inicio;
        inicio = novoNo;
        Console.WriteLine($"'{funcionario.Nome}' inserido no início da lista.");
    }

    // b) Implemente a operação de inserção de um elemento pelo fim.
    public void InserirFim(Funcionario funcionario)
    {
        No novoNo = new No(funcionario);

        // Se a lista estiver vazia, o novo nó se torna o início.
        if (inicio == null)
        {
            inicio = novoNo;
        }
        else
        {
            // Percorre a lista até encontrar o último nó.
            No atual = inicio;
            while (atual.Proximo != null)
            {
                atual = atual.Proximo;
            }
            // O último nó agora aponta para o novo nó.
            atual.Proximo = novoNo;
        }
        Console.WriteLine($"'{funcionario.Nome}' inserido no fim da lista.");
    }

    // c) Implemente a operação de consulta (busca) de um elemento por nome do funcionário.
    public Funcionario BuscarPorNome(string nome)
    {
        No atual = inicio;
        while (atual != null)
        {
            // Compara o nome ignorando maiúsculas/minúsculas.
            if (atual.Funcionario.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\nFuncionário '{nome}' encontrado!");
                return atual.Funcionario;
            }
            atual = atual.Proximo;
        }
        Console.WriteLine($"\nFuncionário '{nome}' não encontrado na lista.");
        return null; // Retorna null se não encontrar.
    }

    // d) Implemente a operação de remoção de um elemento pelo início.
    public void RemoverInicio()
    {
        if (inicio == null)
        {
            Console.WriteLine("Não é possível remover: a lista está vazia.");
            return;
        }

        Console.WriteLine($"'{inicio.Funcionario.Nome}' removido do início da lista.");
        // O início da lista passa a ser o segundo elemento.
        inicio = inicio.Proximo;
    }

    // e) Implemente a operação de remoção de um elemento pelo fim.
    public void RemoverFim()
    {
        if (inicio == null)
        {
            Console.WriteLine("Não é possível remover: a lista está vazia.");
            return;
        }

        // Se houver apenas um elemento na lista.
        if (inicio.Proximo == null)
        {
            Console.WriteLine($"'{inicio.Funcionario.Nome}' removido do fim da lista.");
            inicio = null;
            return;
        }

        // Percorre a lista para encontrar o penúltimo nó.
        No penultimo = inicio;
        while (penultimo.Proximo.Proximo != null)
        {
            penultimo = penultimo.Proximo;
        }

        Console.WriteLine($"'{penultimo.Proximo.Funcionario.Nome}' removido do fim da lista.");
        // Remove a referência para o último nó.
        penultimo.Proximo = null;
    }

    // f) Implemente a operação de percurso (impressão).
    public void Percorrer()
    {
        if (inicio == null)
        {
            Console.WriteLine("\nA lista está vazia.");
            return;
        }

        Console.WriteLine("\n--- Lista de Funcionários ---");
        No atual = inicio;
        int count = 1;
        while (atual != null)
        {
            Console.WriteLine($"{count}. {atual.Funcionario}");
            atual = atual.Proximo;
            count++;
        }
        Console.WriteLine("---------------------------\n");
    }
}