using ALAYSchoolManager.Domain.Entidades.Shared;
using ALAYSchoolManager.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository.Shared;

public class ModuloRepository : BaseSharedRepository<Modulos>, IModuloRepository
{
    public ModuloRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
}