using System;
using System.Globalization;

public struct Funcionario
{
    // --- Atributos ---
    public string Nome { get; private set; }
    public string Cargo { get; private set; }
    public double Salario { get; private set; }
    public int CargaHorariaSemanal { get; private set; }

    // --- Construtor ---
    public Funcionario(string nome, string cargo, double salarioInicial, int cargaHorariaInicial)
    {
        this.Nome = nome;
        this.Cargo = cargo;
        this.Salario = salarioInicial;
        this.CargaHorariaSemanal = cargaHorariaInicial;
    }

    // É 'private' porque, segundo a regra, só deve ser usada pela operação 'promover'.
    private void aumentoSalarialPorPromocaoEmValor(double valorDoAumento)
    {
        if (valorDoAumento > 0)
        {
            this.Salario += valorDoAumento;
        }
    }

    // Promove o funcionário para um novo cargo e ajusta o salário.
    public void promover(string novoCargo, double aumento)
    {
        Console.WriteLine($"=> PROMOÇÃO: Promovendo '{this.Nome}' para o cargo de '{novoCargo}' com um aumento de {aumento:C}.");
        this.Cargo = novoCargo;
        this.aumentoSalarialPorPromocaoEmValor(aumento); // Usa a operação interna
    }

    // Aplica um desconto por falta.
    public void descontoSalarialPorFaltaEmValor(double valorDoDesconto)
    {
        Console.WriteLine($"=> DESCONTO: Aplicando um desconto de {valorDoDesconto:C} por falta.");
        if (valorDoDesconto > 0)
        {
            this.Salario -= valorDoDesconto;
            // Garante que o salário não fique negativo
            if (this.Salario < 0)
            {
                this.Salario = 0;
            }
        }
    }

    // Aumenta a carga horária e reajusta o salário proporcionalmente.
    public void aumentarCargaHorariaDeTrabalho(int novaCargaHoraria)
    {
        Console.WriteLine($"=> AJUSTE DE CARGA HORÁRIA: Aumentando a carga horária para {novaCargaHoraria}h semanais.");
        if (novaCargaHoraria > this.CargaHorariaSemanal && this.CargaHorariaSemanal > 0)
        {
            // 1. Calcula o valor da hora atual do funcionário
            double valorPorHora = this.Salario / this.CargaHorariaSemanal;

            // 2. Atualiza a carga horária
            this.CargaHorariaSemanal = novaCargaHoraria;

            // 3. Reajusta o salário com base no valor da hora e na nova carga horária
            this.Salario = valorPorHora * this.CargaHorariaSemanal;
        }
        else
        {
            Console.WriteLine("A nova carga horária deve ser maior que a atual.");
        }
    }

    // Imprime todos os dados do funcionário de forma organizada.
    public void imprimir()
    {
        Console.WriteLine("\n------------------------------------");
        Console.WriteLine($"Dados do Funcionário:");
        Console.WriteLine($"  Nome: {this.Nome}");
        Console.WriteLine($"  Cargo: {this.Cargo}");
        // Formata o salário como moeda local (R$)
        Console.WriteLine($"  Salário: {this.Salario:C}");
        Console.WriteLine($"  Carga Horária: {this.CargaHorariaSemanal}h/semana");
        Console.WriteLine("------------------------------------\n");
    }
}