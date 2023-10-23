using System.ComponentModel.DataAnnotations.Schema;
using ALAYSchoolManager.Application.ViewModels.Shared;

namespace ALAYSchoolManager.Application.ViewModels;

public class MatriculasViewModel
{
    public int MatriculaId { get; set; }

    #region Modulo
    public int MatriculaModuloId { get; set; }

    [NotMapped]
    public List<ModulosViewModel> MatriculaModulos { get; set; }
    #endregion



    //#region Aluno
    //[Required]
    //public AlunosViewModel MatricuAluno { get; set; }
    //#endregion
    //#region AnoAcademico
    //public AnoAcademicoViewModel MatriculaAnoAcademico { get; set; }
    //#endregion
    //#region Emolumentos

    //public List<EmolumentosModulosViewModel> EmolumentosObrigatorios { get; set; }
    //public List<EmolumentosModulosViewModel> EmolumentosOpcionais { get; set; }

    //#endregion
    //#region Usuario Cadastrador
    //public required string MatriculaUsuarioId { get; set; }


    //#endregion
    //public DateTime DataHora { get; set; }
}