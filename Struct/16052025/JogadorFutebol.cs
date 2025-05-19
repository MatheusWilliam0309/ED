using System;

public class JogadorFutebol
{
    public string Nome { get; set; }
    public string Clube { get; set; }
    public int Idade { get; set; }
    public int CartoesAmarelos { get; private set; }
    public int CartoesVermelhos { get; private set; }

    public JogadorFutebol(string nome, string clube, int idade)
    {
        Nome = nome;
        Clube = clube;
        Idade = idade;
        CartoesAmarelos = 0;
        CartoesVermelhos = 0;
    }

    public void RegistrarCartaoAmarelo() => CartoesAmarelos++;
    public void RegistrarCartaoVermelho() => CartoesVermelhos++;
    public bool TemVinculoComClube() => !string.IsNullOrWhiteSpace(Clube);

    public void Imprimir()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Clube: {(TemVinculoComClube() ? Clube : "Sem clube")}");
        Console.WriteLine($"Cartões Amarelos: {CartoesAmarelos}");
        Console.WriteLine($"Cartões Vermelhos: {CartoesVermelhos}");
    }
}

public static class Exercicio1A
{
    public static void Executar()
    {
        var jogador = new JogadorFutebol("Lucas Silva", "Corinthians", 25);
        jogador.RegistrarCartaoAmarelo();
        jogador.RegistrarCartaoAmarelo();
        jogador.RegistrarCartaoVermelho();
        jogador.Imprimir();

        Console.WriteLine(jogador.TemVinculoComClube()
            ? "O jogador tem vínculo com clube."
            : "O jogador está sem clube.");
    }
}