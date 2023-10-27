using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository;

public class DepartamentosRepository : BaseRepository<Departamentos>, IDepartamentosRepository
{
    public DepartamentosRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
}