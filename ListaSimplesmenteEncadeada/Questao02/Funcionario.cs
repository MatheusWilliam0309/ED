public class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Telefone { get; set; }
    public double Salario { get; set; }

    public Funcionario(string nome, int idade, string telefone, double salario)
    {
        Nome = nome;
        Idade = idade;
        Telefone = telefone;
        Salario = salario;
    }

    // Sobrescreve o método ToString para facilitar a impressão dos dados.
    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}, Telefone: {Telefone}, Salário: {Salario:C}";
    }
}