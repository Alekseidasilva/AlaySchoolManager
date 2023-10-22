using ALAYSchoolManagment.Domain.Entidades.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManagment.Infra.Data.Context;

namespace ALAYSchoolManagment.Infra.Data.Repository.Shared;

public class FormasPagamentoRepository : BaseSharedRepository<FormasPagamentos>, IFormasPagamentoRepository
{
    public FormasPagamentoRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
}