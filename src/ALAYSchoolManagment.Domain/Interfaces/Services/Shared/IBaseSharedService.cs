namespace ALAYSchoolManagment.Domain.Interfaces.Services.Shared;

public interface IBaseSharedService<TEntidade> : IDisposable where TEntidade : class
{
    TEntidade ObterPorId(int id);
    IEnumerable<TEntidade> ObterTodos();
}