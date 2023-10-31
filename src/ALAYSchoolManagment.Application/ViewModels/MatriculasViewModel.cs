using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ALAYSchoolManager.Application.ViewModels.Shared;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.ViewModels;

public class MatriculasViewModel
{
    public int MatriculaId { get; set; }

    #region Modulos
    public short MatriculaModuloId { get; set; }

    [NotMapped]
    public IEnumerable<ModulosViewModel> MatriculaModulos { get; set; }
    #endregion
    #region Aluno
    [Required]
    public AlunosViewModel MatriculaAluno { get; set; }
    #endregion
    //#region AnoAcademico
    //public AnoAcademicoViewModel MatriculaAnoAcademico { get; set; }
    //#endregion
    #region Emolumentos

    public List<EmolumentosModulosViewModel> EmolumentosObrigatorios { get; set; }
    public List<EmolumentosModulosViewModel> EmolumentosOpcionais { get; set; }

    #endregion
    #region Usuario Cadastrador
    public string MatriculaUsuarioId { get; set; }


    #endregion
    public DateTime DataHora { get; set; }
}