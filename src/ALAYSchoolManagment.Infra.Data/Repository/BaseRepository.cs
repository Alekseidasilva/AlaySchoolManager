using System.Linq.Expressions;
using ALAYSchoolManager.Domain.Entidades.Shared;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Infra.Data.AdoNet;
using ALAYSchoolManager.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ALAYSchoolManager.Infra.Data.Repository;

public class BaseRepository<TEntidade> : IBaseRepository<TEntidade> where TEntidade : EntidadeBase
{
    #region Variaveis
    protected AlaySchoolGetDbContext _db;
    protected DbSet<TEntidade> dbSet;
    protected SQLServer _ado;
    #endregion
    #region Construtores
    public BaseRepository(AlaySchoolGetDbContext context)
    {
        _db = context;
        dbSet = _db.Set<TEntidade>();
        _ado = new SQLServer();

    }


    #endregion
    #region Metodos
    public virtual void Adicionar(TEntidade obj)
    {
        dbSet.Add(obj);
    }

    public virtual void Actualizar(TEntidade obj)
    {
        dbSet.Update(dbSet.Find(obj.Id));
    }

    public virtual void Remover(TEntidade obj)
    {
        dbSet.Remove(obj);
    }

    public virtual TEntidade? ObterPorId(int id)
    {
        return dbSet.AsNoTracking().FirstOrDefault(f => f.Id == id);
    }

    public virtual IEnumerable<TEntidade> ObterTodos()
    {
        return dbSet.ToList();
    }

    public IEnumerable<TEntidade> Buscar(Expression<Func<TEntidade, bool>> predicate)
    {
        return dbSet.AsNoTracking().Where(predicate);
    }
    public void Dispose()
    {
        _db.Dispose();
        GC.SuppressFinalize(this);
    }


    #endregion

}