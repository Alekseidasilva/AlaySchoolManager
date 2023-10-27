namespace ALAYSchoolManager.Domain.Interfaces.Services;

public interface IBaseService<TEntidade> : IDisposable where TEntidade : class
{
    TEntidade Adicionar(TEntidade obj);
    TEntidade Actualizar(TEntidade obj);
    TEntidade Remover(TEntidade obj);
    IEnumerable<TEntidade> ObterTodos();
    TEntidade? ObterPorId(int id);
}