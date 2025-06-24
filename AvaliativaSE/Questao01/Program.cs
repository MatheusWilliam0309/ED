using System;
using System.Globalization;

// Classe principal para demonstrar o uso da struct Funcionario
public class Program
{
    public static void Main(string[] args)
    {
        // Define a cultura para pt-BR para que o formato da moeda (R$) seja exibido corretamente.
        CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);

        // 1. Cria uma instância da struct Funcionario
        Console.WriteLine("Criando um novo funcionário...");
        Funcionario func1 = new Funcionario("Carlos Silva", "Analista Jr.", 3500.00, 40);

        // 2. Imprime os dados iniciais
        func1.imprimir();

        // 3. Usa a operação de promoção
        func1.promover("Analista Pleno", 1200.00);
        func1.imprimir();

        // 4. Usa a operação de aumentar a carga horária
        func1.aumentarCargaHorariaDeTrabalho(44);
        func1.imprimir();

        // 5. Usa a operação de desconto
        func1.descontoSalarialPorFaltaEmValor(150.75);
        func1.imprimir();
    }
}