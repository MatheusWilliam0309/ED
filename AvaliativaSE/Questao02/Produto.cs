using System;
using System.Globalization;

public struct Produto
{
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public string Fabricante { get; private set; }
    public double Preco { get; private set; }

    // --- Construtor ---
    public Produto(string nome, string descricao, string fabricante, double preco, int qtdEstoque)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        this.Fabricante = fabricante;
        this.Preco = preco;
        this.QuantidadeEstoque = qtdEstoque;
    }

    public void aplicarCupomDesconto(double porcentagem)
    {
        if (porcentagem <= 0 || porcentagem > 100)
        {
            Console.WriteLine("=> AVISO: Porcentagem de desconto inválida. O valor deve ser entre 1 e 100.");
            return;
        }

        double valorDoDesconto = this.Preco * (porcentagem / 100.0);
        this.Preco -= valorDoDesconto;

        Console.WriteLine($"=> CUPOM APLICADO: Desconto de {porcentagem}% ({valorDoDesconto:C}) aplicado com sucesso!");
    }
}