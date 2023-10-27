namespace ALAYSchoolManager.Infra.Data.Interfaces;

public interface IUnitOfWork
{
    public void Commit(List<string> erros);
    public void Rollbackst();
}