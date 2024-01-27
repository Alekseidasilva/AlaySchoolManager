using ALAYSchoolManager.Domain.Entidades.Shared;

namespace ALAYSchoolManager.Domain.Entidades;

public class Matriculas : EntidadeBase
{
    public Matriculas()
    {
        MatriculaAlunoId = new Aluno();
        MatriculaModuloId = new Modulos();
        //MatriculaAnoAcademicoId = new AnoAcademico();
    }
    public Aluno MatriculaAlunoId { get; set; }
    public Modulos MatriculaModuloId { get; set; }
    public AnoAcademico MatriculaAnoAcademicoId { get; set; }
    public DateTime MatriculaDataHora { get; set; } = DateTime.Now;
    public string? MatriculaUsuarioId { get; set; }




    public override bool EstaConsistente()
    {
        throw new NotImplementedException();
    }
}






