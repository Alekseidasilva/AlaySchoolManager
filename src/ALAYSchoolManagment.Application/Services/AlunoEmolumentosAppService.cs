using ALAYSchoolManagment.Application.Interfaces;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using AutoMapper;
using System.Linq.Expressions;
using ALAYSchoolManager.Application.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManagment.Application.Services;

public class AlunoEmolumentosAppService : IAlunoEmolumentosApp
{
    #region Variaveis
    private readonly IAlunoEmolumentosRepository _alunoEmolumentosRepository;
    private readonly IMapper _mapper;
    #endregion
    #region Construtores
    public AlunoEmolumentosAppService(IAlunoEmolumentosRepository alunoEmolumentosRepository, IMapper mapper)
    {
        _alunoEmolumentosRepository = alunoEmolumentosRepository;
        _mapper = mapper;
    }
    #endregion
    #region Metodos
    public AlunoEmolumentosViewModel Adicionar(AlunoEmolumentosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public AlunoEmolumentosViewModel Actualizar(AlunoEmolumentosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public AlunoEmolumentosViewModel Remover(AlunoEmolumentosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public AlunoEmolumentosViewModel? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<AlunoEmolumentosViewModel> ObterTodos()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<AlunoEmolumentosViewModel> Buscar(Expression<Func<AlunoEmolumentosViewModel, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public SelectList ObterLista()
    {
        throw new NotImplementedException();
    }
    public void Dispose()
    {
        _alunoEmolumentosRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}