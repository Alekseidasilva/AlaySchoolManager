using ALAYSchoolManager.Application.Interfaces.Shared;
using ALAYSchoolManager.Application.ViewModels.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Services.Shared;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.Services.Shared;

public class ModulosAppService : IModulosApp
{
    #region Variaveis
    private readonly IModulosService _moduloService;
    private readonly IMapper _mapper;
    #endregion
    #region Construtores
    public ModulosAppService(IModulosService moduloRepository, IMapper mapper)
    {
        _moduloService = moduloRepository;
        _mapper = mapper;
    }


    #endregion
    #region Metodos
    public SelectList ObterLista()
    {
        return new SelectList(ObterTodos(), "ModuloId", "ModuloDesignacao");
    }
    public ModulosViewModel ObterPorId(int id)
    {
        return _mapper.Map<ModulosViewModel>(_moduloService.ObterPorId(id));
    }
    public IEnumerable<ModulosViewModel> ObterTodos()
    {
        return _mapper.Map<IEnumerable<ModulosViewModel>>(_moduloService.ObterTodos());
    }
    public void Dispose()
    {
        _moduloService.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}