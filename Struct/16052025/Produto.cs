using System;

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; private set; }
    public int QuantidadeEstoque { get; private set; }

    public Produto(string nome, decimal preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        QuantidadeEstoque = estoque;
    }

    public void AplicarCupomDescontoValor(decimal valor)
    {
        Preco -= valor;
        if (Preco < 0) Preco = 0;
    }

    public void AplicarCupomDescontoPorcentagem(decimal porcentagem)
    {
        Preco -= Preco * (porcentagem / 100);
        if (Preco < 0) Preco = 0;
    }

    public bool VerificarQuantidadeEmEstoque()
    {
        return QuantidadeEstoque > 0;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco}");
        Console.WriteLine($"Estoque: {QuantidadeEstoque}");
        Console.WriteLine($"Disponibilidade: {(VerificarQuantidadeEmEstoque() ? "Em estoque" : "Esgotado")}");
    }
}

public static class Exercicio1C
{
    public static void Executar()
    {
        var produto = new Produto("Camiseta", 100m, 10);
        produto.AplicarCupomDescontoValor(20m);
        produto.AplicarCupomDescontoPorcentagem(10m);
        produto.Imprimir();
    }
}