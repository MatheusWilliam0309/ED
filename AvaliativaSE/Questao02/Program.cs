using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        // Define a cultura para pt-BR para que o formato da moeda (R$) seja exibido corretamente.
        CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);

        // 1. Cria um novo produto
        Console.WriteLine("Cadastrando um novo produto...");
        Produto meuProduto = new Produto(
            "Mouse Gamer RGB", 
            "Mouse óptico com 6 botões e iluminação RGB customizável.", 
            "TechGamer", 
            180.50, 
            50
        );

        // 2. Mostra os dados iniciais do produto
        meuProduto.imprimir();

        // 3. Aplica um cupom de desconto de 15%
        meuProduto.aplicarCupomDesconto(15);
        
        // 4. Mostra os dados após o desconto
        meuProduto.imprimir();
        
        // 5. Demonstração dos métodos de estoque (bônus)
        meuProduto.removerEstoque(5); // Simula uma venda
        meuProduto.adicionarEstoque(10); // Simula recebimento de mais produtos
        
        // 6. Mostra o estado final do produto
        meuProduto.imprimir();

    }
}