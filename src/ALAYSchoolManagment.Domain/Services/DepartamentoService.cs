using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Domain.Interfaces.Services;

namespace ALAYSchoolManager.Domain.Services;

public class DepartamentoService : IDepartamentoService
{
    #region Variaveis
    private readonly IDepartamentosRepository _departamentosRepository;
    #endregion
    #region Construtores
    public DepartamentoService(IDepartamentosRepository departamentosRepository)
    {
        _departamentosRepository = departamentosRepository;
    }
    #endregion
    #region Metodos
    public Departamentos Adicionar(Departamentos obj)
    {
        throw new NotImplementedException();
    }

    public Departamentos Actualizar(Departamentos obj)
    {
        throw new NotImplementedException();
    }

    public Departamentos Remover(Departamentos obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Departamentos> ObterTodos()
    {
        return _departamentosRepository.ObterTodos();
    }

    public Departamentos? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }
    public void Dispose()
    {
        _departamentosRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}