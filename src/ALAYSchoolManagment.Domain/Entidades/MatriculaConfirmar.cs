using ALAYSchoolManager.Domain.Entidades.Shared;

namespace ALAYSchoolManager.Domain.Entidades;

public class MatriculaConfirmar : EntidadeBase
{
    public string AlunoNumMatricula { get; set; }
    public Aluno AlunoNMatricula { get; set; }
    public AnoAcademico AnoAcademicoId { get; set; }
    public DateTime DataHora { get; set; }
    public string UsuarioCadastrador { get; set; }
    public override bool EstaConsistente()
    {
        throw new NotImplementedException();
    }
}