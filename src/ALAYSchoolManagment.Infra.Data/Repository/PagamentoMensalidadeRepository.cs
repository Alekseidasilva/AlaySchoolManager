using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Infra.Data.Context;

namespace ALAYSchoolManagment.Infra.Data.Repository
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
