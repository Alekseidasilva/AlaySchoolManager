

using ALAYSchoolManagment.Application.Interfaces.Shared;
using ALAYSchoolManagment.Application.ViewModels.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ALAYSchoolManagment.Application.Services.Shared;

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
    public SelectList ObterLista()
    {
        return new SelectList(ObterTodos(), "EstadoCivilId", "EstadoCivilDesignacao");
    }

    public void Dispose()
    {
        _estadoCivilRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}