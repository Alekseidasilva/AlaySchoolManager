namespace ALAYSchoolManagment.Application.ViewModels;

public class MatriculaConfirmarViewModel
{
    public AlunosViewModel AlunosNMatricula { get; set; }
    public AnoAcademicoViewModel AnoAcademico { get; set; }
    public DateTime DataHora { get; set; }
    public string UsuarioCadastrador { get; set; }
}