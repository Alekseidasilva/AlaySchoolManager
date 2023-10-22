namespace ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;

public interface IBaseSharedRepository<TEntidade> : IDisposable where TEntidade : class
{
    TEntidade? ObterPorId(int id);
    IEnumerable<TEntidade> ObterTodos();
}