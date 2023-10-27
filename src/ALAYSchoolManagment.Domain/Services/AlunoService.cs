using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Domain.Interfaces.Services;

namespace ALAYSchoolManager.Domain.Services;

public class AlunoService : IAlunoService
{
    #region Variaveis
    private readonly IAlunoRepository _alunoRepository;
    #endregion
    #region Construtores
    public AlunoService(IAlunoRepository alunoRepository)
    {
        _alunoRepository = alunoRepository;
    }
    #endregion
    #region Metodos
    public Aluno Adicionar(Aluno obj)
    {
        throw new NotImplementedException();
    }

    public Aluno Actualizar(Aluno obj)
    {
        throw new NotImplementedException();
    }

    public Aluno Remover(Aluno obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Aluno> ObterTodos()
    {
        throw new NotImplementedException();
    }

    public Aluno? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Aluno? BuscarPeloNMatricula(string? nMatricula)
    {
        return _alunoRepository.BuscarPeloNMatricula(nMatricula);
    }

    public void Dispose()
    {
        _alunoRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}