using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository
{
    public class PagamentoMensalidadeRepository : BaseRepository<PagamentoMensalidade>, IPagamentoMensalidadeRepository
    {
        public PagamentoMensalidadeRepository(AlaySchoolGetDbContext context) : base(context)
        {
        }
        public void EfectuarPagamento(Pagamentos pagamento)
        {
            throw new NotImplementedException();
        }
    }
}
