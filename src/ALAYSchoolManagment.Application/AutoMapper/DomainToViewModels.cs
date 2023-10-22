using ALAYSchoolManagment.Application.ViewModels;
using ALAYSchoolManagment.Application.ViewModels.Shared;
using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Entidades.Shared;
using ALAYSchoolManagment.Domain.Entidades.Vo;
using AutoMapper;

namespace ALAYSchoolManagment.Application.AutoMapper;

public class DomainToViewModels : Profile
{
    public DomainToViewModels()
    {
        #region Shared
        #region Estado Civil
        CreateMap<EstadoCivilVo, EstadoCivilViewModel>()
            .ForMember(est => est.EstadoCivilId, opt => opt.MapFrom(e => e.EstadoCivilId))
            .ForMember(est => est.EstadoCivilDesignacao, opt => opt.MapFrom(e => e.EstadoCivilDesignacao));
        #endregion
        #region Generos
        CreateMap<GenerosVo, GenerosViewModel>()
            .ForMember(gen => gen.GeneroId, opt => opt.MapFrom(g => g.GeneroId))
            .ForMember(gen => gen.GeneroDesignacao, opt => opt.MapFrom(g => g.GeneroDesignacao));



        #endregion
        #region Modulo
        CreateMap<Modulos, ModulosViewModel>()
            .ForMember(m => m.ModuloId, opt => opt.MapFrom(m => m.ModuloId))
            .ForMember(m => m.ModuloDesignacao, opt => opt.MapFrom(m => m.ModuloDesignacao));
        #endregion
        #region Emolumentos factores
        CreateMap<EmolumentosFatores, EmolumentosFatoresViewModel>()
            .ForMember(EmoVm => EmoVm.EmolumentoFactorId, opt => opt.MapFrom(g => g.EmolumentoFatorId))
            .ForMember(EmoVm => EmoVm.EmolumentoFactorDesigncao, opt => opt.MapFrom(g => g.EmolumentoFatorDesignacao));




        #endregion
        #endregion
        #region Matricula
        CreateMap<Matriculas, MatriculasViewModel>()
        #region Matricula
        .ForPath(matriVm => matriVm.MatriculaId, opt => opt.MapFrom(matric => matric.Id))
        .ForPath(matriVm => matriVm.DataHora, opt => opt.MapFrom(matric => matric.MatriculaDataHora))

        #endregion
        #region Aluno
        .ForPath(matriVm => matriVm.MatricuAluno.AlunoId, opt => opt.MapFrom(matric => matric.MatriculaAlunoId.Id))
        .ForPath(matriVm => matriVm.MatricuAluno.AlunoNMatricula, opt => opt.MapFrom(matric => matric.MatriculaAlunoId.AlunoNMatricula))
        .ForPath(matriVm => matriVm.MatricuAluno.AlunoNomeCompleto, opt => opt.MapFrom(matric => matric.MatriculaAlunoId.PessoaNomeCompleto))
        .ForPath(matriVm => matriVm.MatricuAluno.AlunoContribuinte, opt => opt.MapFrom(matric => matric.MatriculaAlunoId.PessoaContribuinte))
        .ForPath(matriVm => matriVm.MatricuAluno.AlunoDataNascimento, opt => opt.MapFrom(matric => matric.MatriculaAlunoId.PessoaDataNascimento))
        .ForPath(matriVm => matriVm.MatricuAluno.AlunoDataCadastro, opt => opt.MapFrom(matric => matric.MatriculaAlunoId.PessoaDataCadastro))
        .ForPath(matriVm => matriVm.MatricuAluno.AlunoGenero.GeneroId, opt => opt.MapFrom(matric => matric.MatriculaAlunoId.PessoaGenero.GeneroId))
        .ForPath(matriVm => matriVm.MatricuAluno.AlunoGenero.GeneroDesignacao, opt => opt.MapFrom(matric => matric.MatriculaAlunoId.PessoaGenero.GeneroDesignacao))
        .ForPath(matriVm => matriVm.MatricuAluno.AlunoEstadoCivil.EstadoCivilId, opt => opt.MapFrom(matric => matric.MatriculaAlunoId.PessoaEstadoCivil.EstadoCivilId))
        .ForPath(matriVm => matriVm.MatricuAluno.AlunoEstadoCivil.EstadoCivilDesignacao, opt => opt.MapFrom(matric => matric.MatriculaAlunoId.PessoaEstadoCivil.EstadoCivilDesignacao))
        .ForPath(matriVm => matriVm.MatricuAluno.AlunoEstado, opt => opt.MapFrom(matric => matric.MatriculaAlunoId.PessoaEstado))
        #endregion
        #region Modulo
        .ForPath(matriVm => matriVm.MatriculaModuloId, opt => opt.MapFrom(matric => matric.MatriculaModuloId.ModuloId))
        .ForPath(matriVm => matriVm.MatriculaModuloDesignacao, opt => opt.MapFrom(matric => matric.MatriculaModuloId.ModuloDesignacao))
        #endregion
        #region AnoAcademico
        //.ForPath(matriVm => matriVm.MatriculaAnoAcademico, opt => opt.MapFrom(matric => matric.MatriculaAnoAcademicoId.AnoAcademicoId))
        //.ForPath(matriVm => matriVm.MatriculaAnoAcademicoDesignacao, opt => opt.MapFrom(matric => matric.MatriculaAnoAcademicoId.AnoAcademicoDesignacao))
        #endregion
        #region Usuario
        .ForPath(matriVm => matriVm.MatriculaUsuarioId, opt => opt.MapFrom(matric => matric.MatriculaUsuarioId))
        #endregion
        ;
        #endregion
        #region MatriculaConfirmar
        CreateMap<MatriculaConfirmar, MatriculaConfirmarViewModel>()
        #region Aluno
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoId, opt => opt.MapFrom(matric => matric.AlunoNMatricula.Id))
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoNMatricula, opt => opt.MapFrom(matric => matric.AlunoNMatricula.AlunoNMatricula))
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoNomeCompleto, opt => opt.MapFrom(matric => matric.AlunoNMatricula.PessoaNomeCompleto))
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoContribuinte, opt => opt.MapFrom(matric => matric.AlunoNMatricula.PessoaContribuinte))
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoDataNascimento, opt => opt.MapFrom(matric => matric.AlunoNMatricula.PessoaDataNascimento))
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoDataCadastro, opt => opt.MapFrom(matric => matric.AlunoNMatricula.PessoaDataCadastro))
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoGenero.GeneroId, opt => opt.MapFrom(matric => matric.AlunoNMatricula.PessoaGenero.GeneroId))
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoGenero.GeneroDesignacao, opt => opt.MapFrom(matric => matric.AlunoNMatricula.PessoaGenero.GeneroDesignacao))
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoEstadoCivil.EstadoCivilId, opt => opt.MapFrom(matric => matric.AlunoNMatricula.PessoaEstadoCivil.EstadoCivilId))
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoEstadoCivil.EstadoCivilDesignacao, opt => opt.MapFrom(matric => matric.AlunoNMatricula.PessoaEstadoCivil.EstadoCivilDesignacao))
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoEstado, opt => opt.MapFrom(matric => matric.AlunoNMatricula.PessoaEstado))
            .ForPath(matriVm => matriVm.AlunosNMatricula.AlunoObservacao, opt => opt.MapFrom(matric => matric.AlunoNMatricula.Observacao))
        #endregion
        #region AnoAcademico
        .ForPath(matriVm => matriVm.AnoAcademico.AnoAcademicoId, opt => opt.MapFrom(matric => matric.AnoAcademicoId.AnoAcademicoId))
        .ForPath(matriVm => matriVm.AnoAcademico.AnoAcademicoDesignacao, opt => opt.MapFrom(matric => matric.AnoAcademicoId.AnoAcademicoDesignacao))
        #endregion
        .ForPath(m => m.DataHora, opt => opt.MapFrom(x => x.DataHora))
            .ForPath(m => m.UsuarioCadastrador, opt => opt.MapFrom(x => x.UsuarioCadastrador))
            ;


        #endregion
        #region Aluno

        //CreateMap<Aluno, AlunosViewModel>();


        #endregion
        #region Emolumentos
        CreateMap<Emolumentos, EmolumentosViewModel>()
            .ForMember(emo => emo.EmolumentoId, opt => opt.MapFrom(em => em.Id))
            .ForMember(emo => emo.EmolumentoDesignacao, opt => opt.MapFrom(em => em.EmolumentoDesignacao));
        #endregion
        #region EmolumentosModulos
        CreateMap<EmolumentosModulos, EmolumentosModulosViewModel>()
            .ForPath(des => des.EmolumentoModuloModuloId.ModuloId,
                opt => opt.MapFrom(x => x.EmolumentoModuloModuloId.ModuloId))
            .ForPath(des => des.EmolumentoModuloModuloId.ModuloDesignacao,
                opt => opt.MapFrom(x => x.EmolumentoModuloModuloId.ModuloDesignacao))
            .ForPath(des => des.Emolumentos.EmolumentoId, opt => opt.MapFrom(x => x.EmolumentoModuloEmolumentoId.Id))
            .ForPath(des => des.Emolumentos.EmolumentoDesignacao, opt => opt.MapFrom(x => x.EmolumentoModuloEmolumentoId.EmolumentoDesignacao))
            .ForPath(des => des.EmolumentoModuloFactorId.EmolumentoFactorId,
                opt => opt.MapFrom(x => x.EmolumentoModuloFactorId.EmolumentoFatorId))
            .ForPath(des => des.EmolumentoModuloFactorId.EmolumentoFactorDesigncao,
                opt => opt.MapFrom(x => x.EmolumentoModuloFactorId.EmolumentoFatorDesignacao))
            .ForPath(des => des.EmolumentoModuloPreco, opt => opt.MapFrom(x => x.EmolumentoModuloPreco))
            .ForPath(des => des.UsuarioCadastrador, opt => opt.MapFrom(x => x.UsuarioCadastrador))
            .ForPath(des => des.EmolumentoModuloEstado, opt => opt.MapFrom(x => x.EmolumentoModuloEstado));
        #endregion
        #region FormasPagamento
        CreateMap<FormasPagamentos, FormasPagamentosViewModel>();
        #endregion

    }
}