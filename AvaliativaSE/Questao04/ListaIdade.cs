using System;

public class ListaIdades
{
    private NoIdade inicio;

    public ListaIdades()
    {
        this.inicio = null;
    }

    // a) Insere uma nova idade no início da lista.
    public void inserirInicio(int idade)
    {
        // 1. Cria um novo nó com a idade fornecida.
        NoIdade novoNo = new NoIdade(idade);

        // 2. O 'Proximo' do novo nó passa a ser o 'inicio' atual da lista.
        novoNo.Proximo = this.inicio;

        // 3. O 'inicio' da lista agora é o novo nó que acabamos de criar.
        this.inicio = novoNo;
        
        Console.WriteLine($"-> Idade {idade} inserida no início da lista.");
    }

    // b) Percorre e imprime todos os elementos (idades) da lista.
    public void percorrer()
    {
        Console.WriteLine("\n--- Imprimindo lista de idades ---");
        
        if (this.inicio == null)
        {
            Console.WriteLine("A lista está vazia.");
            return;
        }

        // Cria um nó temporário que começa no início da lista.
        NoIdade atual = this.inicio;

        Console.Write("Idades: ");
        // Loop que continua enquanto não chegarmos ao fim da lista (null).
        while (atual != null)
        {
            Console.Write(atual.Idade + " -> ");
            // Avança para o próximo nó.
            atual = atual.Proximo;
        }
        Console.WriteLine("FIM");
        Console.WriteLine("----------------------------------\n");
    }

    // c) Consulta se uma idade específica existe na lista.
    public bool consultar(int idade)
    {
        Console.Write($"- Consultando pela idade {idade}... ");
        
        NoIdade atual = this.inicio;

        while (atual != null)
        {
            if (atual.Idade == idade)
            {
                return true;
            }
            atual = atual.Proximo;
        }

        return false;
    }
}