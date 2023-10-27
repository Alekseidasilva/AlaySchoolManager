using System.Linq.Expressions;
using ALAYSchoolManager.Application.Interfaces;
using ALAYSchoolManager.Application.ViewModels;
using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Services;
using ALAYSchoolManager.Infra.Data.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.Services;

public class MatriculaAppService : IMatriculasApp
{
    #region Variaveis
    private readonly IMatriculaService _matriculaService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    #endregion
    #region Construtores
    public MatriculaAppService(IMatriculaService matriculaService, IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._matriculaService = matriculaService;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    #endregion
    #region Metodos
    public string EfectuarMatricula(MatriculasViewModel matricVm)
    {
        var a = _mapper.Map<MatriculasViewModel>(_matriculaService.EfectuarMatricula(_mapper.Map<Matriculas>(matricVm)));
        List<string> listaErro = new List<string>();
        _unitOfWork.Commit(listaErro);

        return string.Empty;
    }
    public MatriculasViewModel Adicionar(MatriculasViewModel obj)
    {
        throw new NotImplementedException();
    }
    public MatriculasViewModel Actualizar(MatriculasViewModel obj)
    {
        throw new NotImplementedException();
    }

    public MatriculasViewModel Remover(MatriculasViewModel obj)
    {
        throw new NotImplementedException();
    }

    public MatriculasViewModel? ObterPorId(int id)
    {
        return _mapper.Map<MatriculasViewModel>(_matriculaService.ObterPorId(id));
    }
    public IEnumerable<MatriculasViewModel> ObterTodos()
    {
        return _mapper.Map<IEnumerable<MatriculasViewModel>>(_matriculaService.ObterTodos());
    }

    public IEnumerable<MatriculasViewModel> Buscar(Expression<Func<MatriculasViewModel, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public SelectList ObterLista()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        this._matriculaService.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}