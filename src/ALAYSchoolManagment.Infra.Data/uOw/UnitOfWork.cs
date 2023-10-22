using ALAYSchoolManagment.Infra.Data.Context;
using ALAYSchoolManagment.Infra.Data.Interfaces;

namespace ALAYSchoolManagment.Infra.Data.uOw;

public class UnitOfWork : IUnitOfWork
{
    private readonly AlaySchoolGetDbContext _dbContext;

    public UnitOfWork(AlaySchoolGetDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Commit(List<string> erros)
    {
        if (!erros.Any())
            _dbContext.SaveChanges();


    }

    public void Rollbackst()
    {

    }
}