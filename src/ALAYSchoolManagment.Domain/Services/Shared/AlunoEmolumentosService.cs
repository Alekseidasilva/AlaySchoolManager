using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Services.Shared;

namespace ALAYSchoolManagment.Domain.Services.Shared;

public class AlunoEmolumentosService : IAlunoEmolumentosService
{
    #region Variaveis
    private readonly IAlunoEmolumentosRepository _alunoEmolumentosRepository;
    #endregion
    #region Construtores
    public AlunoEmolumentosService(IAlunoEmolumentosRepository alunoEmolumentosRepository)
    {
        _alunoEmolumentosRepository = alunoEmolumentosRepository;
    }
    #endregion
    #region Metodos

    public void Adicionar(AlunoEmolumentos alunoEmolumentos)
    {
        throw new NotImplementedException();
    }

    public void Remover(AlunoEmolumentos alunoEmolumentos)
    {
        throw new NotImplementedException();
    }

    public List<AlunoEmolumentos> ListarAlunoEmolmentos(long alunoNMatricula)
    {
        return _alunoEmolumentosRepository.ListarAlunoEmolmentos(alunoNMatricula);
    }

    public AlunoEmolumentos? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<AlunoEmolumentos> ObterTodos()
    {
        return _alunoEmolumentosRepository.ObterTodos();
    }

    public void Dispose()
    {
        _alunoEmolumentosRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion



}