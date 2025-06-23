public class No
{
    public Disciplina Disciplina { get; set; }
    public No Proximo { get; set; }

    public No(Disciplina disciplina)
    {
        Disciplina = disciplina;
        Proximo = null;
    }
}