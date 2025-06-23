public class No
{
    public Funcionario Funcionario { get; set; }
    public No Proximo { get; set; }

    public No(Funcionario funcionario)
    {
        Funcionario = funcionario;
        Proximo = null; // Quando um nó é criado, ele não aponta para ninguém.
    }
}