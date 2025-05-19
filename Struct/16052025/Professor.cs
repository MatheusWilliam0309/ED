using System;

public class Professor
{
    public string Nome { get; set; }
    public decimal Salario { get; private set; }
    public int CargaHoraria { get; private set; }

    public Professor(string nome, decimal salario, int cargaHoraria)
    {
        Nome = nome;
        Salario = salario;
        CargaHoraria = cargaHoraria;
    }

    public void ReajusteSalarialEmValor(decimal valor)
    {
        Salario += valor;
    }

    public void ReajusteSalarialEmPorcentagem(decimal porcentagem)
    {
        Salario += Salario * (porcentagem / 100);
    }

    public void DescontoSalarialPorFaltaEmValor(decimal valor)
    {
        Salario -= valor;
        if (Salario < 0) Salario = 0;
    }

    public void DescontoSalarialPorFaltaEmPorcentagem(decimal porcentagem)
    {
        Salario -= Salario * (porcentagem / 100);
        if (Salario < 0) Salario = 0;
    }

    public void AumentarCargaHoraria(int horas, decimal valorReajuste)
    {
        CargaHoraria += horas;
        ReajusteSalarialEmValor(valorReajuste);
    }

    public void Imprimir()
    {
        Console.WriteLine($"Professor: {Nome}");
        Console.WriteLine($"Salário: R$ {Salario}");
        Console.WriteLine($"Carga Horária: {CargaHoraria}h/semana");
    }
}

public static class Exercicio1D
{
    public static void Executar()
    {
        var professor = new Professor("Ana Paula", 5000m, 40);
        professor.ReajusteSalarialEmPorcentagem(10);
        professor.DescontoSalarialPorFaltaEmValor(300);
        professor.AumentarCargaHoraria(4, 500);
        professor.Imprimir();
    }
}