﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ALAYSchoolManager.Application.ViewModels.Shared;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.ViewModels;

public class AlunosViewModel
{
    public AlunosViewModel()
    {

    }
    public int AlunoId { get; set; }
    public string? AlunoNMatricula { get; set; }

    [Required]
    public string AlunoNomeCompleto { get; set; }
    [Required]
    public string AlunoContribuinte { get; set; }
    [Required]
    [DataType(DataType.PhoneNumber)]
    public string AlunoTelefone { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime AlunoDataNascimento { get; set; }
    [Required]
    public GenerosViewModel AlunoGenero { get; set; }
    [Required]
    public EstadoCivilViewModel AlunoEstadoCivil { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime AlunoDataCadastro { get; set; }
    public bool AlunoEstado { get; set; }
    public string AlunoObservacao { get; set; }



    #region NotMapped
    [NotMapped]
    public List<SelectListItem> GenerosSelectList { get; set; }
    [NotMapped]
    public List<SelectListItem> EstadosCivilSelectList { get; set; }
    #endregion
}