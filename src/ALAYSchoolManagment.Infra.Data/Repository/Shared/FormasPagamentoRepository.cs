using ALAYSchoolManager.Domain.Entidades.Shared;
using ALAYSchoolManager.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository.Shared;

public class FormasPagamentoRepository : BaseSharedRepository<FormasPagamentos>, IFormasPagamentoRepository
{
    public FormasPagamentoRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
}