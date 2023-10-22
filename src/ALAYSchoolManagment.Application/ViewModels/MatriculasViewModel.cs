using System.ComponentModel.DataAnnotations;

namespace ALAYSchoolManagment.Application.ViewModels;

public class MatriculasViewModel
{
    public int MatriculaId { get; set; }
    #region Aluno
    [Required]
    public AlunosViewModel MatricuAluno { get; set; }
    #endregion
    #region Modulo
    public int MatriculaModuloId { get; set; }
    public string MatriculaModuloDesignacao { get; set; }
    #endregion
    #region AnoAcademico
    public AnoAcademicoViewModel MatriculaAnoAcademico { get; set; }
    #endregion
    #region Emolumentos

    public List<EmolumentosModulosViewModel> EmolumentosObrigatorios { get; set; }
    public List<EmolumentosModulosViewModel> EmolumentosOpcionais { get; set; }

    #endregion
    #region Usuario Cadastrador
    public required string MatriculaUsuarioId { get; set; }


    #endregion
    public DateTime DataHora { get; set; }
}