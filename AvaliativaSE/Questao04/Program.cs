using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Cria uma nova instância da lista de idades.
        ListaIdades listaDeAlunos = new ListaIdades();

        listaDeAlunos.percorrer();

        // a) Inserindo algumas idades no início.
        listaDeAlunos.inserirInicio(22);
        listaDeAlunos.inserirInicio(19);
        listaDeAlunos.inserirInicio(25);
        listaDeAlunos.inserirInicio(18);

        // b) Percorrendo a lista para ver os resultados.
        listaDeAlunos.percorrer();

        // c) Consultando idades na lista.
        
        // Teste com uma idade que existe.
        bool encontrou = listaDeAlunos.consultar(19);
        if (encontrou)
        {
            Console.WriteLine("Resultado: Encontrado!");
        }
        else
        {
            Console.WriteLine("Resultado: Não encontrado.");
        }
        
        // Teste com uma idade que NÃO existe.
        encontrou = listaDeAlunos.consultar(30);
         if (encontrou)
        {
            Console.WriteLine("Resultado: Encontrado!");
        }
        else
        {
            Console.WriteLine("Resultado: Não encontrado.");
        }
    }
}