using ALAYSchoolManagment.Infra.Data.AdoNet;
using ALAYSchoolManagment.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ALAYSchoolManagment.Infra.Data.Repository.Shared;

public class BaseSharedRepository<TEntidade> : IDisposable where TEntidade : class
{
    #region Variaveis
    protected AlaySchoolGetDbContext _db;
    protected DbSet<TEntidade> dbSet;
    protected SQLServer _ado;


    #endregion
    #region Construtores
    public BaseSharedRepository(AlaySchoolGetDbContext context)
    {
        _db = context;
        dbSet = _db.Set<TEntidade>();
        _ado = new SQLServer();
    }


    #endregion
    #region Metodos
    public virtual TEntidade? ObterPorId(int id)
    {
        return dbSet.AsNoTracking().FirstOrDefault();
    }
    public virtual IEnumerable<TEntidade> ObterTodos()
    {
        return dbSet.ToList();
    }
    public void Dispose()
    {

        _db.Dispose();
        GC.SuppressFinalize(this);
    }


    #endregion

}