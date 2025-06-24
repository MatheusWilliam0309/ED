using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        // Define a cultura para pt-BR para que o formato da moeda (R$) seja exibido corretamente.
        CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);

        ListaCarros concessionaria = new ListaCarros();
        Carro carro1 = new Carro("Onix", "Chevrolet", new DateOnly(2023, 5, 10), 85000.00m);
        Carro carro2 = new Carro("Mobi", "Fiat", new DateOnly(2022, 11, 20), 72000.00m);
        Carro carro3 = new Carro("Creta", "Hyundai", new DateOnly(2024, 1, 30), 140000.00m);
        Carro carro4 = new Carro("Corolla", "Toyota", new DateOnly(2023, 9, 15), 150000.00m);

        // d) Inserindo carros no fim da lista
        concessionaria.inserirFim(carro1);
        concessionaria.inserirFim(carro2);
        concessionaria.inserirFim(carro3);
        concessionaria.inserirFim(carro4);

        // g) Percorrendo e imprimindo a lista completa
        concessionaria.percorrer();

        // e) Consultando por um modelo
        Console.WriteLine("Buscando pelo modelo 'Creta'...");
        Carro carroEncontrado = concessionaria.consultarPorModelo("Creta");
        if (carroEncontrado != null)
        {
            Console.WriteLine($"Carro encontrado: {carroEncontrado}\n");
        }
        else
        {
            Console.WriteLine("Carro não encontrado.\n");
        }

        Console.WriteLine("Buscando pelo modelo 'Fusca'...");
        carroEncontrado = concessionaria.consultarPorModelo("Fusca");
        if (carroEncontrado != null)
        {
            Console.WriteLine($"Carro encontrado: {carroEncontrado}\n");
        }
        else
        {
            Console.WriteLine("Carro não encontrado.\n");
        }

        // f) Removendo carros do fim da lista
        concessionaria.removerFim();
        concessionaria.percorrer();

        concessionaria.removerFim();
        concessionaria.percorrer();
    }
}