using System;

public class EquipeEsports
{
    public string Nome { get; set; }
    public DateTime DataEstreia { get; set; }
    public int CampeonatosVencidos { get; private set; }
    public decimal ValorTotalPremiacoes { get; private set; }

    public EquipeEsports(string nome, DateTime dataEstreia)
    {
        Nome = nome;
        DataEstreia = dataEstreia;
        CampeonatosVencidos = 0;
        ValorTotalPremiacoes = 0;
    }

    public void RegistrarCampeonatoVencido(decimal valorPremio)
    {
        CampeonatosVencidos++;
        AtualizarValorTotalPremiacoes(valorPremio);
    }

    public void AtualizarValorTotalPremiacoes(decimal valor)
    {
        ValorTotalPremiacoes += valor;
    }

    public bool VerificarAnoEstreia()
    {
        return DataEstreia.Year == DateTime.Now.Year;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Nome da Equipe: {Nome}");
        Console.WriteLine($"Data de Estreia: {DataEstreia.ToShortDateString()}");
        Console.WriteLine($"Campeonatos Vencidos: {CampeonatosVencidos}");
        Console.WriteLine($"Valor Total de Premiações: R$ {ValorTotalPremiacoes}");
        Console.WriteLine($"Status: {(VerificarAnoEstreia() ? "Novata" : "Veterana")}");
    }
}

public static class Exercicio1B
{
    public static void Executar()
    {
        var equipe = new EquipeEsports("Fúria Esports", new DateTime(2024, 3, 15));
        equipe.RegistrarCampeonatoVencido(20000);
        equipe.RegistrarCampeonatoVencido(15000);
        equipe.Imprimir();
    }
}