using ALAYSchoolManagment.Domain.Entidades.Vo;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManagment.Infra.Data.Context;

namespace ALAYSchoolManagment.Infra.Data.Repository.Shared;

public class EstadoCivilRepository : BaseSharedRepository<EstadoCivilVo>, IEstadoCivilRepository
{
    public EstadoCivilRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
}