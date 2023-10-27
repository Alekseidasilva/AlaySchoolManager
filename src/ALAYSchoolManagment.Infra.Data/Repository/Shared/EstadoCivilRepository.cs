using ALAYSchoolManager.Domain.Entidades.Vo;
using ALAYSchoolManager.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository.Shared;

public class EstadoCivilRepository : BaseSharedRepository<EstadoCivilVo>, IEstadoCivilRepository
{
    public EstadoCivilRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
}