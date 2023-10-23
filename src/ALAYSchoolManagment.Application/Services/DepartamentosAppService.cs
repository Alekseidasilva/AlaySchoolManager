using ALAYSchoolManagment.Application.Interfaces;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using System.Linq.Expressions;
using ALAYSchoolManager.Application.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManagment.Application.Services;

public class DepartamentosAppService : IDepartamentosApp
{
    #region Variaveis
    private readonly IDepartamentosRepository _departamentosRepository;
    #endregion
    #region Construtores
    public DepartamentosAppService(IDepartamentosRepository departamentosRepository)
    {
        this._departamentosRepository = departamentosRepository;
    }
    #endregion
    #region Metodos
    public DepartamentosViewModel Adicionar(DepartamentosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public DepartamentosViewModel Actualizar(DepartamentosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public DepartamentosViewModel Remover(DepartamentosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public DepartamentosViewModel? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DepartamentosViewModel> ObterTodos()
    {
        List<DepartamentosViewModel> departamentosViewModels = new List<DepartamentosViewModel>();
        foreach (var dep in _departamentosRepository.ObterTodos())
        {
            var depVM = new DepartamentosViewModel
            {
                //Id = dep.Id,
                //DepartamentoDesignacao = dep.DepartamentoDesignacao
            };
            departamentosViewModels.Add(depVM);
        }
        return departamentosViewModels;
    }

    public IEnumerable<DepartamentosViewModel> Buscar(Expression<Func<DepartamentosViewModel, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public SelectList ObterLista()
    {
        var departamentos = ObterTodos();
        var lista = new SelectList(departamentos, "Id", "DepartamentoDesignacao");
        return lista;
    }

    public void Dispose()
    {
        _departamentosRepository.Dispose();
        GC.SuppressFinalize(this);
    }


    #endregion

}