using ALAYSchoolManagment.Domain.Entidades.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManagment.Infra.Data.Context;

namespace ALAYSchoolManagment.Infra.Data.Repository.Shared;

public class ModuloRepository : BaseSharedRepository<Modulos>, IModuloRepository
{
    public ModuloRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
}