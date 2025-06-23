using System;

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Criando a lista e inserindo elementos no início
        Console.WriteLine("--- 1. Criando a lista e inserindo no início ---");
        Lista lista = new(); 
        lista.inserirInicio(10);
        lista.inserirInicio(7);
        lista.inserirInicio(12);
        lista.inserirInicio(-5);
        lista.imprimir(); // Estado da lista: -5 -> 12 -> 7 -> 10

        Console.WriteLine("\n-------------------------------------------------");

        // 2. Testando o novo método 'inserirFinal'
        Console.WriteLine("\n--- 2. Testando o método inserirFinal ---");
        Console.WriteLine("Inserindo o valor 99 no final...");
        lista.inserirFinal(99);
        lista.imprimir(); // Estado da lista: -5 -> 12 -> 7 -> 10 -> 99

        Console.WriteLine("\n-------------------------------------------------");

        // 3. Testando o novo método 'removerInicio'
        Console.WriteLine("\n--- 3. Testando o método removerInicio ---");
        try
        {
            int valorRemovido = lista.removerInicio();
            Console.WriteLine($"Valor removido do início: {valorRemovido}");
            lista.imprimir(); // Estado da lista: 12 -> 7 -> 10 -> 99
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("\n-------------------------------------------------");

        // 4. Testando o novo método 'removerFim'
        Console.WriteLine("\n--- 4. Testando o método removerFim ---");
        try
        {
            int valorRemovido = lista.removerFim();
            Console.WriteLine($"Valor removido do fim: {valorRemovido}");
            lista.imprimir(); // Estado da lista: 12 -> 7 -> 10
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("\n-------------------------------------------------");

        // 5. Testando o método original 'remover(valor)'
        Console.WriteLine("\n--- 5. Testando o método remover(valor) ---");
        Console.WriteLine("Removendo o valor 7 (um nó do meio)...");
        bool removeu = lista.remover(7);
        if(removeu) Console.WriteLine("Elemento removido com sucesso!");
        
        lista.imprimir(); // Estado da lista: 12 -> 10
        
        Console.WriteLine("\n-------------------------------------------------");

        // 6. Testando o método original 'consulta(valor)'
        Console.WriteLine("\n--- 6. Testando o método consulta(valor) ---");
        int valor = 10;
        No noAnterior = null;
        No noAtual = null;
        bool verif = lista.consulta(valor, ref noAtual, ref noAnterior);
        if (verif)
            Console.WriteLine($"A busca pelo valor {valor} encontrou um resultado!");
        else
            Console.WriteLine($"A busca pelo valor {valor} NÃO encontrou um resultado!");

        valor = -12;
        verif = lista.consulta(valor, ref noAtual, ref noAnterior);
         if (verif)
            Console.WriteLine($"A busca pelo valor {valor} encontrou um resultado!");
        else
            Console.WriteLine($"A busca pelo valor {valor} NÃO encontrou um resultado!");

        Console.WriteLine("\n-------------------------------------------------");

        // 7. Esvaziando a lista e testando casos de erro
        Console.WriteLine("\n--- 7. Esvaziando a lista e testando remoção em lista vazia ---");
        lista.remover(10);
        lista.remover(12);
        lista.imprimir(); // A lista agora deve estar vazia

        Console.WriteLine("\nTentando remover do fim de uma lista vazia...");
        try
        {
            lista.removerFim();
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERRO CAPTURADO: {e.Message}");
        }
    }
}