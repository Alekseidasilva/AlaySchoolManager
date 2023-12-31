﻿using System.Linq.Expressions;
using ALAYSchoolManager.Application.Interfaces;
using ALAYSchoolManager.Application.ViewModels;
using ALAYSchoolManager.Domain.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.Services;

public class EmolumentosModulosAppService : IEmolumentosModulosApp
{
    #region variaveis
    private readonly IEmolumentosModulosServices _emolumentosModulosServices;
    private readonly IMapper _mapper;
    #endregion
    #region Construtores
    public EmolumentosModulosAppService(IEmolumentosModulosServices emolumentosModulosServices, IMapper mapper)
    {
        _emolumentosModulosServices = emolumentosModulosServices;
        _mapper = mapper;
    }
    #endregion
    #region Metodos
    public EmolumentosModulosViewModel Adicionar(EmolumentosModulosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public EmolumentosModulosViewModel Actualizar(EmolumentosModulosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public EmolumentosModulosViewModel Remover(EmolumentosModulosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public EmolumentosModulosViewModel? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<EmolumentosModulosViewModel> ObterTodos()
    {
        return _mapper.Map<IEnumerable<EmolumentosModulosViewModel>>(_emolumentosModulosServices.ObterTodos());
    }

    public IEnumerable<EmolumentosModulosViewModel> Buscar(Expression<Func<EmolumentosModulosViewModel, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public SelectList ObterLista()
    {
        throw new NotImplementedException();
    }
    public List<EmolumentosModulosViewModel> ListarObrigatoriosActivos(short moduloId)
    {
        return ObterTodos().Where(x =>
            x.EmolumentoModuloEstado.Equals(true) & x.EmolumentoModuloFactorId.EmolumentoFactorId.Equals(1) & x.EmolumentoModuloModuloId.ModuloId.Equals(moduloId)).ToList();
    }

    public List<EmolumentosModulosViewModel> ListarOpcionaisActivos(short moduloId)
    {
        return ObterTodos().Where(x =>
            x.EmolumentoModuloEstado.Equals(true) && x.EmolumentoModuloFactorId.EmolumentoFactorId.Equals(2) & x.EmolumentoModuloModuloId.ModuloId.Equals(moduloId)).ToList();
    }
    public List<EmolumentosModulosViewModel> ListarActivos()
    {
        return ObterTodos().Where(x => x.EmolumentoModuloEstado.Equals(true)).ToList();
    }

    public decimal ObterPrecoEmolumento(short emolumentoId)
    {
        return ObterTodos().Where(m => m.Emolumentos.EmolumentoId.Equals(emolumentoId))
            .Select(x => x.EmolumentoModuloPreco).FirstOrDefault();
    }

    public void Dispose()
    {
        _emolumentosModulosServices.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}