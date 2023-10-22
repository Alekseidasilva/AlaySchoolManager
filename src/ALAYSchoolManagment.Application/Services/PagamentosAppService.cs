using ALAYSchoolManagment.Application.Interfaces;
using ALAYSchoolManagment.Application.ViewModels;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using AutoMapper;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManagment.Application.Services;

public class PagamentosAppService : IPagamentosApp
{

    #region Variaveis

    private readonly IPagamentosRepository _pagamentosRepository;
    private readonly IMapper _mapper;
    #endregion
    #region Construtores
    public PagamentosAppService(IPagamentosRepository pagamentosRepository, IMapper mapper)
    {
        _pagamentosRepository = pagamentosRepository;
        _mapper = mapper;
    }
    #endregion
    #region Metodos
    public PagamentosViewModel Adicionar(PagamentosViewModel obj)
    {
        throw new NotImplementedException();
    }
    public PagamentosViewModel Actualizar(PagamentosViewModel obj)
    {
        throw new NotImplementedException();
    }
    public PagamentosViewModel Remover(PagamentosViewModel obj)
    {
        throw new NotImplementedException();
    }
    public PagamentosViewModel? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PagamentosViewModel> ObterTodos()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PagamentosViewModel> Buscar(Expression<Func<PagamentosViewModel, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public SelectList ObterLista()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _pagamentosRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion

}