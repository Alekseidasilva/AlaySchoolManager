using ALAYSchoolManager.Application.Interfaces.Shared;
using ALAYSchoolManager.Application.ViewModels.Shared;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using ALAYSchoolManager.Domain.Interfaces.Repository.Shared;

namespace ALAYSchoolManager.Application.Services.Shared;

public class EstadoCivilAppService : IEstadoCivilApp
{
    #region Variaveis
    private readonly IEstadoCivilRepository _estadoCivilRepository;
    private readonly IMapper _mapper;
    #endregion
    #region Construtores
    public EstadoCivilAppService(IEstadoCivilRepository estadoCivilRepository, IMapper mapper)
    {
        _estadoCivilRepository = estadoCivilRepository;
        _mapper = mapper;
    }
    #endregion
    #region Metodos
    public IEnumerable<EstadoCivilViewModel> ObterTodos()
    {
        return _mapper.Map<IEnumerable<EstadoCivilViewModel>>(_estadoCivilRepository.ObterTodos());
    }
    public EstadoCivilViewModel ObterPorId(int id)
    {
        return _mapper.Map<EstadoCivilViewModel>(_estadoCivilRepository.ObterPorId(id));
    }
    public List<SelectListItem> ObterLista()
    {
        List<SelectListItem> listItems = new List<SelectListItem>();
        foreach (var item in ObterTodos())
            listItems.Add(new SelectListItem(item.EstadoCivilDesignacao, item.EstadoCivilId.ToString()));
        return listItems;

    }

    public void Dispose()
    {
        _estadoCivilRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}