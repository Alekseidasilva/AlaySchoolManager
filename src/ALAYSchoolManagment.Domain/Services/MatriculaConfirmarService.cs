using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Domain.Interfaces.Services;

namespace ALAYSchoolManagment.Domain.Services;

public class MatriculaConfirmarService : IMatriculaConfirmarService
{
    #region Variaveis
    private readonly IMatriculaConfirmarRepository _matriculaConfirmarRepository;
    #endregion
    #region Construtores
    public MatriculaConfirmarService(IMatriculaConfirmarRepository matriculaConfirmarRepository)
    {
        _matriculaConfirmarRepository = matriculaConfirmarRepository;
    }
    #endregion
    #region Metodos
    public MatriculaConfirmar Adicionar(MatriculaConfirmar obj)
    {
        throw new NotImplementedException();
    }
    public MatriculaConfirmar Actualizar(MatriculaConfirmar obj)
    {
        throw new NotImplementedException();
    }
    public MatriculaConfirmar Remover(MatriculaConfirmar obj)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<MatriculaConfirmar> ObterTodos()
    {
        return _matriculaConfirmarRepository.ObterTodos();
    }
    public MatriculaConfirmar? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }
    public void Dispose()
    {
        _matriculaConfirmarRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion

}