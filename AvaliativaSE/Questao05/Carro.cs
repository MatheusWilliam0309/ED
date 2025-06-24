using System;
using System.Globalization;

public class Carro
{
    public string NomeModelo { get; set; }
    public string FabricanteMontadora { get; set; }
    public DateOnly DataFabricacao { get; set; }
    public decimal Preco { get; set; }

    public Carro(string nomeModelo, string fabricante, DateOnly dataFabricacao, decimal preco)
    {
        NomeModelo = nomeModelo;
        FabricanteMontadora = fabricante;
        DataFabricacao = dataFabricacao;
        Preco = preco;
    }

    // Sobrescreve o método ToString() para facilitar a impressão dos dados.
    public override string ToString()
    {
        // Formata a data e a moeda para o padrão brasileiro.
        return $"Modelo: {NomeModelo} | Fabricante: {FabricanteMontadora} | Fabricado em: {DataFabricacao.ToString("dd/MM/yyyy")} | Preço: {Preco:C}";
    }
}
