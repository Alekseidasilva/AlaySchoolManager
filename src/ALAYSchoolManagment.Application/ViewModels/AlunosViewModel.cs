using System.ComponentModel.DataAnnotations;
using ALAYSchoolManagment.Application.ViewModels.Shared;

namespace ALAYSchoolManagment.Application.ViewModels;

public class AlunosViewModel
{
    public AlunosViewModel()
    {

    }
    public int AlunoId { get; set; }
    public string? AlunoNMatricula { get; set; }


    public string? AlunoNomeCompleto { get; set; }
    public string? AlunoContribuinte { get; set; }
    //[DataType(DataType.Date)]
    public DateTime AlunoDataNascimento { get; set; }
    public GenerosViewModel AlunoGenero { get; set; }
    public EstadoCivilViewModel AlunoEstadoCivil { get; set; }
    public DateTime AlunoDataCadastro { get; set; }
    public bool AlunoEstado { get; set; }
    public string AlunoObservacao { get; set; }
}