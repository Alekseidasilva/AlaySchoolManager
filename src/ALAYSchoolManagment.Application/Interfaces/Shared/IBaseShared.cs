using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.Interfaces.Shared;

public interface IBaseShared<TEntidade> : IDisposable where TEntidade : class
{
    IEnumerable<TEntidade> ObterTodos();
    TEntidade ObterPorId(int id);
    SelectList ObterLista();
}