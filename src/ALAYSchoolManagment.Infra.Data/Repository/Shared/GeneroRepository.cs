using ALAYSchoolManager.Domain.Entidades.Vo;
using ALAYSchoolManager.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository.Shared;

public class GeneroRepository : BaseSharedRepository<GenerosVo>, IGeneroRepository
{
    public GeneroRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
}