public class Disciplina
{
    public string Nome { get; set; }
    public string Periodo { get; set; }
    public int CargaHoraria { get; set; }
    public string ProfessorResponsavel { get; set; }

    public Disciplina(string nome, string periodo, int cargaHoraria, string professorResponsavel)
    {
        Nome = nome;
        Periodo = periodo;
        CargaHoraria = cargaHoraria;
        ProfessorResponsavel = professorResponsavel;
    }

    // Sobrescreve o método ToString para uma impressão clara dos dados.
    public override string ToString()
    {
        return $"Disciplina: {Nome}, Período: {Periodo}, C.H: {CargaHoraria}h, Professor: {ProfessorResponsavel}";
    }
}