using System.Linq.Expressions;
using ALAYSchoolManager.Application.Interfaces;
using ALAYSchoolManager.Application.ViewModels;
using ALAYSchoolManagment.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.Services;

public class EmolumentosAppService : IEmolumentosApp
{
    #region Variaveis
    private readonly IEmolumentosService _emolumentosService;
    #endregion
    #region Construtores
    public EmolumentosAppService(IEmolumentosService emolumentosService)
    {
        _emolumentosService = emolumentosService;
    }
    #endregion
    #region Metodos
    public EmolumentosViewModel Adicionar(EmolumentosViewModel obj)
    {
        throw new NotImplementedException();
    }
    public EmolumentosViewModel Actualizar(EmolumentosViewModel obj)
    {
        throw new NotImplementedException();
    }
    public EmolumentosViewModel Remover(EmolumentosViewModel obj)
    {
        throw new NotImplementedException();
    }
    public EmolumentosViewModel? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<EmolumentosViewModel> ObterTodos()
    {
        throw new NotImplementedException();
    }
    public IEnumerable<EmolumentosViewModel> Buscar(Expression<Func<EmolumentosViewModel, bool>> predicate)
    {
        throw new NotImplementedException();
    }
    public SelectList ObterLista()
    {
        throw new NotImplementedException();
    }
    public IEnumerable<EmolumentosViewModel> ObterEmolumentosObrigatorios(int moduloId, int factorId)
    {
        var emol = _emolumentosService.ObterEmolumentosObrigatorios(moduloId, factorId);
        List<EmolumentosViewModel> emolumentosViewModels = new List<EmolumentosViewModel>();
        //foreach (Emolumentos item in emol)
        //{
        //    var emolVm = new EmolumentosViewModel
        //    {
        //        Modulos = item.Modulos,
        //        EmolumentoDesignacao = item.EmolumentoDesignacao,
        //        EmolumentoFatores = item.EmolumentoFatores,
        //        EmolumentoPreco = item.EmolumentoPreco
        //    };
        //    emolumentosViewModels.Add(emolVm);

        //}
        return emolumentosViewModels;
    }

    public IEnumerable<EmolumentosViewModel> ObterEmolumentosOpcionais(int moduloId, int factorId)
    {
        var emol = _emolumentosService.ObterEmolumentosObrigatorios(moduloId, factorId);
        List<EmolumentosViewModel> emolumentosViewModels = new List<EmolumentosViewModel>();
        //foreach (Emolumentos item in emol)
        //{
        //    var emolVm = new EmolumentosViewModel
        //    {
        //        Modulos = item.Modulos,
        //        EmolumentoDesignacao = item.EmolumentoDesignacao,
        //        EmolumentoFatores = item.EmolumentoFatores,
        //        EmolumentoPreco = item.EmolumentoPreco
        //    };
        //    emolumentosViewModels.Add(emolVm);

        //}
        return emolumentosViewModels;
    }

    public void Dispose()
    {
        _emolumentosService.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion

}