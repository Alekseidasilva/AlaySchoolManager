using ALAYSchoolManager.Domain.Entidades;

namespace ALAYSchoolManager.Domain.Interfaces.Repository
{
    public interface IPagamentoMensalidadeRepository : IBaseRepository<PagamentoMensalidade>
    {
        void EfectuarPagamento(Pagamentos pagamento);
    }
}
