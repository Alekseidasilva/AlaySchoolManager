using ALAYSchoolManagment.Domain.Entidades.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Services.Shared;

namespace ALAYSchoolManagment.Domain.Services.Shared;

public class FormasPagamentoService : IFormasPagamentoService
{
    #region Variaveis
    private readonly IFormasPagamentoRepository _formasPagamentoRepository;
    #endregion
    #region Construtores
    public FormasPagamentoService(IFormasPagamentoRepository formasPagamentoRepository)
    {
        _formasPagamentoRepository = formasPagamentoRepository;
    }
    #endregion
    #region Metodos
    public FormasPagamentos? ObterPorId(int id)
    {
        return _formasPagamentoRepository.ObterPorId(id);
    }

    public IEnumerable<FormasPagamentos> ObterTodos()
    {
        return _formasPagamentoRepository.ObterTodos();
    }
    public void Dispose()
    {
        _formasPagamentoRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion

}