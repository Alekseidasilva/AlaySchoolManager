namespace ALAYSchoolManager.Domain.Interfaces.Services.Identity;

public interface IUsuarioService<TEntidade> : IDisposable where TEntidade : class
{
    TEntidade Adicionar(TEntidade obj);
    TEntidade Actualizar(TEntidade obj);
    TEntidade Remover(TEntidade obj);
    IEnumerable<TEntidade> ObterTodos();
    TEntidade? ObterPorId(Guid id);
}