using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.Interfaces;

public interface IBaseApp<TEntidade> : IDisposable where TEntidade : class
{
    TEntidade Adicionar(TEntidade obj);
    TEntidade Actualizar(TEntidade obj);
    TEntidade Remover(TEntidade obj);
    TEntidade? ObterPorId(int id);
    IEnumerable<TEntidade> ObterTodos();
    IEnumerable<TEntidade> Buscar(Expression<Func<TEntidade, bool>> predicate);
    SelectList ObterLista();
}