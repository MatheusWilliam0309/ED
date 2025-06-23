using System;

public class ListaDisciplinas
{
    private No inicio;

    public ListaDisciplinas()
    {
        inicio = null;
    }

    // a) Implemente a operação de inserção ordenada de um elemento por nome da disciplina.
    public void InserirOrdenado(Disciplina disciplina)
    {
        No novoNo = new No(disciplina);
        
        // Caso 1: A lista está vazia ou o novo elemento deve ser o primeiro.
        // string.Compare retorna < 0 se o primeiro nome vem antes do segundo alfabeticamente.
        if (inicio == null || string.Compare(novoNo.Disciplina.Nome, inicio.Disciplina.Nome) < 0)
        {
            novoNo.Proximo = inicio;
            inicio = novoNo;
        }
        else // Caso 2: Procurar a posição correta para inserir no meio ou no fim.
        {
            No atual = inicio;
            // Avança na lista enquanto o próximo elemento for menor que o novo.
            while (atual.Proximo != null && string.Compare(novoNo.Disciplina.Nome, atual.Proximo.Disciplina.Nome) > 0)
            {
                atual = atual.Proximo;
            }
            novoNo.Proximo = atual.Proximo;
            atual.Proximo = novoNo;
        }
        Console.WriteLine($"Disciplina '{disciplina.Nome}' inserida em ordem.");
    }

    // b) Implemente a operação de consulta (busca) por nome da disciplina.
    public Disciplina BuscarPorNome(string nome)
    {
        No atual = inicio;
        while (atual != null)
        {
            if (atual.Disciplina.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\nDisciplina '{nome}' encontrada!");
                return atual.Disciplina;
            }
            // Como a lista está ordenada, se passamos do ponto onde deveria estar, não existe.
            if(string.Compare(atual.Disciplina.Nome, nome) > 0)
            {
                break;
            }
            atual = atual.Proximo;
        }
        Console.WriteLine($"\nDisciplina '{nome}' não encontrada na lista.");
        return null;
    }

    // c) Implemente a operação de remoção de um elemento por nome da disciplina.
    public void RemoverPorNome(string nome)
    {
        if (inicio == null)
        {
            Console.WriteLine("Não é possível remover: a lista está vazia.");
            return;
        }

        // Caso 1: O nó a ser removido é o primeiro (início).
        if (inicio.Disciplina.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Disciplina '{inicio.Disciplina.Nome}' removida da lista.");
            inicio = inicio.Proximo;
            return;
        }

        // Caso 2: O nó a ser removido está no meio ou no fim da lista.
        No atual = inicio;
        // Procura pelo nó anterior ao que será removido.
        while (atual.Proximo != null && !atual.Proximo.Disciplina.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
        {
            atual = atual.Proximo;
        }

        // Se encontrou o nó (atual.Proximo é o nó a ser removido)
        if (atual.Proximo != null)
        {
            Console.WriteLine($"Disciplina '{atual.Proximo.Disciplina.Nome}' removida da lista.");
            atual.Proximo = atual.Proximo.Proximo; // O nó anterior aponta para o nó seguinte, "pulando" o removido.
        }
        else
        {
            Console.WriteLine($"Não foi possível remover: disciplina '{nome}' não encontrada.");
        }
    }

    // d) Implemente a operação de percurso (impressão).
    public void Percorrer()
    {
        if (inicio == null)
        {
            Console.WriteLine("\nA lista de disciplinas está vazia.");
            return;
        }

        Console.WriteLine("\n--- Lista de Disciplinas (Ordem Alfabética) ---");
        No atual = inicio;
        int count = 1;
        while (atual != null)
        {
            Console.WriteLine($"{count}. {atual.Disciplina}");
            atual = atual.Proximo;
            count++;
        }
        Console.WriteLine("------------------------------------------------\n");
    }
}