using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Cria a lista de funcionários
        ListaEncadeada lista = new ListaEncadeada();

        // Criando alguns funcionários para teste
        Funcionario f1 = new Funcionario("Ana", 30, "1111-2222", 3500.00);
        Funcionario f2 = new Funcionario("Carlos", 45, "3333-4444", 5200.50);
        Funcionario f3 = new Funcionario("Maria", 25, "5555-6666", 2800.00);
        Funcionario f4 = new Funcionario("João", 52, "7777-8888", 7100.75);

        // f) Imprimindo a lista vazia
        lista.Percorrer();

        // a) Inserindo no início
        lista.InserirInicio(f2); // Carlos
        lista.InserirInicio(f1); // Ana, Carlos
        lista.Percorrer();

        // b) Inserindo no fim
        lista.InserirFim(f3);    // Ana, Carlos, Maria
        lista.InserirFim(f4);    // Ana, Carlos, Maria, João
        lista.Percorrer();

        // c) Buscando um funcionário
        Funcionario buscado = lista.BuscarPorNome("Carlos");
        if (buscado != null)
        {
            Console.WriteLine($"Dados: {buscado}");
        }

        lista.BuscarPorNome("Pedro"); // Teste com nome inexistente
        Console.WriteLine();

        // d) Removendo do início
        lista.RemoverInicio(); // Remove Ana
        lista.Percorrer();

        // e) Removendo do fim
        lista.RemoverFim(); // Remove João
        lista.Percorrer();

        // Removendo os elementos restantes para testar os limites
        lista.RemoverInicio(); // Remove Carlos
        lista.RemoverFim();    // Remove Maria
        lista.Percorrer();

        // Tentando remover de uma lista vazia
        lista.RemoverInicio();
    }
}