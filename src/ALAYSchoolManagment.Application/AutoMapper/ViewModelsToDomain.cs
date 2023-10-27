using ALAYSchoolManager.Application.ViewModels;
using ALAYSchoolManager.Application.ViewModels.Shared;
using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Entidades.Shared;
using ALAYSchoolManager.Domain.Entidades.Vo;
using AutoMapper;

namespace ALAYSchoolManager.Application.AutoMapper;

public class ViewModelsToDomain : Profile
{
    public ViewModelsToDomain()
    {
        #region Shared

        CreateMap<EstadoCivilViewModel, EstadoCivilVo>();
        CreateMap<GenerosViewModel, GenerosVo>();
        CreateMap<ModulosViewModel, Modulos>();

        #endregion
        #region Matricula
        //CreateMap<MatriculasViewModel, Matriculas>()
        //    .ForPath(m => m.MatriculaAlunoId.Id, opt => opt.MapFrom(de => de.MatricuAlunoId))
        //    .ForPath(m => m.MatriculaAlunoId.AlunoNMatricula, opt => opt.MapFrom(de => de.MatricuAlunoNMatricula))
        //    .ForPath(m => m.MatriculaModuloId.ModuloId, opt => opt.MapFrom(de => de.MatriculaModuloId))
        //    .ForPath(m => m.MatriculaModuloId.ModuloDesignacao, opt => opt.MapFrom(de => de.MatriculaModuloDesignacao))
        //    .ForPath(m => m.MatriculaAnoAcademicoId.AnoAcademicoId, opt => opt.MapFrom(de => de.MatriculaAnoAcademicoId))
        //    .ForPath(m => m.MatriculaAnoAcademicoId.AnoAcademicoDesignacao, opt => opt.MapFrom(de => de.MatriculaAnoAcademicoDesignacao))


        //    ;
        #endregion
        #region Aluno

        CreateMap<AlunosViewModel, Aluno>();


        #endregion

    }
}