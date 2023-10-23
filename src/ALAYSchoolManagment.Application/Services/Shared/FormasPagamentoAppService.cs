using ALAYSchoolManager.Application.Interfaces.Shared;
using ALAYSchoolManager.Application.ViewModels.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Services.Shared;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.Services.Shared;

public class FormasPagamentoAppService : IFormasPagamentoApp
{
    #region Variaveis

    private readonly IFormasPagamentoService _formasPagamentoService;
    private readonly IMapper _mapper;
    #endregion
    #region Construtores
    public FormasPagamentoAppService(IFormasPagamentoService formasPagamentoService, IMapper mapper)
    {
        _formasPagamentoService = formasPagamentoService;
        _mapper = mapper;
    }
    #endregion
    #region Metodos
    public List<SelectListItem> ObterLista()
    {
        throw new NotImplementedException();
    }

    public FormasPagamentosViewModel ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<FormasPagamentosViewModel> ObterTodos()
    {
        return _mapper.Map<IEnumerable<FormasPagamentosViewModel>>(_formasPagamentoService.ObterTodos());
    }

    public void Dispose()
    {
        _formasPagamentoService.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion


}