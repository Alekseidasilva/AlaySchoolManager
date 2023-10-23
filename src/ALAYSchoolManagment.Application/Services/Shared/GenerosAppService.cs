using ALAYSchoolManager.Application.Interfaces.Shared;
using ALAYSchoolManager.Application.ViewModels.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.Services.Shared;

public class GenerosAppService : IGenerosApp
{
    #region Variaveis
    private readonly IGeneroRepository _generoRepository;
    private readonly IMapper _mapper;
    #endregion
    #region Construtores
    public GenerosAppService(IGeneroRepository generoRepository, IMapper mapper)
    {
        _generoRepository = generoRepository;
        _mapper = mapper;
    }
    #endregion
    #region Metodos

    public IEnumerable<GenerosViewModel> ObterTodos()
    {
        return _mapper.Map<IEnumerable<GenerosViewModel>>(_generoRepository.ObterTodos());
    }

    public GenerosViewModel ObterPorId(int id)
    {
        return _mapper.Map<GenerosViewModel>(_generoRepository.ObterPorId(id));
    }

    public SelectList ObterLista()
    {
        // var listItem=new List<SelectListItem>();
        // foreach (var item in ObterTodos())
        // {
        //    listItem.Add(new SelectListItem{Text = item.GeneroDesignacao,Value = item.GeneroId.ToString()});
        // }
        // //return new SelectList(ObterTodos(), "GeneroId", "GeneroDesignacao");
        //return listItem;
        throw new NotImplementedException();

    }

    public void Dispose()
    {
        _generoRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}