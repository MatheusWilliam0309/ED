using System;

public class NoCarro
{
    public Carro Dados { get; set; }
    public NoCarro Proximo { get; set; }

    public NoCarro(Carro carro)
    {
        this.Dados = carro;
        this.Proximo = null;
    }
}

public class ListaCarros
{
    private NoCarro inicio;

    public ListaCarros()
    {
        this.inicio = null;
    }

    // d) Implemente a operação de inserção de um elemento pelo fim.
    public void inserirFim(Carro carro)
    {
        NoCarro novoNo = new NoCarro(carro);

        // Caso 1: A lista está vazia. O novo nó se torna o início.
        if (inicio == null)
        {
            inicio = novoNo;
        }
        else // Caso 2: A lista não está vazia.
        {
            // Percorre a lista até encontrar o último nó.
            NoCarro atual = inicio;
            while (atual.Proximo != null)
            {
                atual = atual.Proximo;
            }
            // O 'proximo' do último nó agora aponta para o novo nó.
            atual.Proximo = novoNo;
        }
        Console.WriteLine($"-> Modelo '{carro.NomeModelo}' inserido no fim da lista.");
    }

    // e) Implemente a operação de consulta (busca) por nome do modelo.
    // OBS: O exercício pedia "nome do funcionário", que foi interpretado como "nome do modelo".
    public Carro consultarPorModelo(string nomeModelo)
    {
        NoCarro atual = inicio;
        while (atual != null)
        {
            // Compara o nome do modelo ignorando maiúsculas/minúsculas.
            if (atual.Dados.NomeModelo.Equals(nomeModelo, StringComparison.OrdinalIgnoreCase))
            {
                return atual.Dados; // Retorna o objeto Carro se encontrar.
            }
            atual = atual.Proximo;
        }
        return null; // Retorna null se não encontrar.
    }

    // f) Implemente a operação de remoção de um elemento pelo fim.
    public Carro removerFim()
    {
        if (inicio == null)
        {
            Console.WriteLine("Não é possível remover: a lista está vazia.");
            return null;
        }

        Carro carroRemovido;

        // Caso 1: A lista tem apenas um elemento.
        if (inicio.Proximo == null)
        {
            carroRemovido = inicio.Dados;
            inicio = null; // A lista fica vazia.
        }
        else // Caso 2: A lista tem mais de um elemento.
        {
            // Percorre a lista para encontrar o penúltimo nó.
            NoCarro penultimo = inicio;
            while (penultimo.Proximo.Proximo != null)
            {
                penultimo = penultimo.Proximo;
            }
            carroRemovido = penultimo.Proximo.Dados;
            penultimo.Proximo = null; // O penúltimo se torna o último.
        }
        
        Console.WriteLine($"<- Modelo '{carroRemovido.NomeModelo}' removido do fim da lista.");
        return carroRemovido;
    }

    // g) Implemente a operação de percurso (impressão).
    public void percorrer()
    {
        Console.WriteLine("\n--- Catálogo de Carros na Lista ---");
        if (inicio == null)
        {
            Console.WriteLine("A lista de carros está vazia.");
            Console.WriteLine("-----------------------------------\n");
            return;
        }

        NoCarro atual = inicio;
        int contador = 1;
        while (atual != null)
        {
            Console.WriteLine($"{contador}. {atual.Dados}");
            atual = atual.Proximo;
            contador++;
        }
        Console.WriteLine("-----------------------------------\n");
    }
}