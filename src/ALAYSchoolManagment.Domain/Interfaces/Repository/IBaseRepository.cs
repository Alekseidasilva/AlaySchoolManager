using System.Linq.Expressions;
using ALAYSchoolManager.Domain.Entidades.Shared;

namespace ALAYSchoolManager.Domain.Interfaces.Repository;

public interface IBaseRepository<TEntidade> : IDisposable where TEntidade : EntidadeBase
{
    void Adicionar(TEntidade obj);
    void Actualizar(TEntidade obj);
    void Remover(TEntidade obj);
    TEntidade? ObterPorId(int id);
    IEnumerable<TEntidade> ObterTodos();
    IEnumerable<TEntidade> Buscar(Expression<Func<TEntidade, bool>> predicate);

}