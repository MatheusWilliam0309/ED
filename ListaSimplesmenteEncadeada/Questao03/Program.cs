using System;

public class Program
{
    public static void Main(string[] args)
    {
        ListaDisciplinas lista = new ListaDisciplinas();

        // Criando disciplinas para teste
        Disciplina d1 = new Disciplina("Cálculo I", "1º Período", 90, "Prof. Dr. Newton");
        Disciplina d2 = new Disciplina("Física Básica", "2º Período", 72, "Prof. Msc. Einstein");
        Disciplina d3 = new Disciplina("Algoritmos e Estrutura de Dados", "2º Período", 90, "Prof. Msc. Turing");
        Disciplina d4 = new Disciplina("Banco de Dados", "3º Período", 72, "Prof. Dra. Codd");
        
        // d) Imprimindo a lista vazia
        lista.Percorrer();

        // a) Inserindo as disciplinas. Elas serão organizadas em ordem alfabética automaticamente.
        lista.InserirOrdenado(d1); // Cálculo I
        lista.InserirOrdenado(d2); // Física Básica
        lista.InserirOrdenado(d3); // Algoritmos...
        lista.InserirOrdenado(d4); // Banco de Dados

        // d) Imprimindo a lista para verificar a ordem
        lista.Percorrer();

        // b) Buscando uma disciplina
        Disciplina disciplinaBuscada = lista.BuscarPorNome("Física Básica");
        if(disciplinaBuscada != null)
        {
            Console.WriteLine($"Dados: {disciplinaBuscada}");
        }
        
        lista.BuscarPorNome("Química Orgânica"); // Teste com disciplina inexistente
        Console.WriteLine();

        // c) Removendo disciplinas
        
        // Removendo do início da lista
        lista.RemoverPorNome("Algoritmos e Estrutura de Dados");
        lista.Percorrer();
        
        // Removendo do meio da lista
        lista.RemoverPorNome("Cálculo I");
        lista.Percorrer();

        // Removendo do fim da lista
        lista.InserirOrdenado(new Disciplina("Zoologia", "5º Período", 60, "Prof. Darwin"));
        lista.Percorrer();
        lista.RemoverPorNome("Zoologia");
        lista.Percorrer();

        // Tentando remover disciplina que não existe
        lista.RemoverPorNome("Inteligência Artificial");
    }
}