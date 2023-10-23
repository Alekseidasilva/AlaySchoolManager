using ALAYSchoolManagment.Application.Interfaces;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using AutoMapper;
using System.Linq.Expressions;
using ALAYSchoolManager.Application.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManagment.Application.Services;

public class AlunosAppService : IAlunosApp
{
    #region Variaveis
    private readonly IAlunoRepository _alunoRepository;
    private readonly IMapper _mapper;
    #endregion
    #region Construtores
    public AlunosAppService(IAlunoRepository alunoRepository, IMapper mapper)
    {
        _alunoRepository = alunoRepository;
        _mapper = mapper;
    }
    #endregion
    #region Metodos
    public AlunosViewModel Adicionar(AlunosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public AlunosViewModel Actualizar(AlunosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public AlunosViewModel Remover(AlunosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public AlunosViewModel? ObterPorId(int id)
    {
        return _mapper.Map<AlunosViewModel>(_alunoRepository.ObterPorId(id));

    }

    public IEnumerable<AlunosViewModel> ObterTodos()
    {
        return _mapper.Map<IEnumerable<AlunosViewModel>>(_alunoRepository.ObterTodos());
    }

    public IEnumerable<AlunosViewModel> Buscar(Expression<Func<AlunosViewModel, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public SelectList ObterLista()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _alunoRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}