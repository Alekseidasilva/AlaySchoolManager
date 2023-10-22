using ALAYSchoolManagment.Domain.Entidades.Vo;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManagment.Infra.Data.Context;

namespace ALAYSchoolManagment.Infra.Data.Repository.Shared;

public class GeneroRepository : BaseSharedRepository<GenerosVo>, IGeneroRepository
{
    public GeneroRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
}