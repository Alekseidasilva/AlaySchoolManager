namespace ALAYSchoolManagment.Domain.Interfaces.Repository.Identity;

public interface IUsuarioRepository<TEntidade> where TEntidade : class
{
    void Adicionar(TEntidade obj);
    void Actualizar(TEntidade obj);
    void Remover(TEntidade obj);
    TEntidade? ObterPorId(Guid id);
    IEnumerable<TEntidade> ObterTodos();

}