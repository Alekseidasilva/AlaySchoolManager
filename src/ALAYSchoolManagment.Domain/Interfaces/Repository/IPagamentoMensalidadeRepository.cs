using ALAYSchoolManagment.Domain.Entidades;

namespace ALAYSchoolManagment.Domain.Interfaces.Repository
{
    public interface IPagamentoMensalidadeRepository : IBaseRepository<PagamentoMensalidade>
    {
        void EfectuarPagamento(Pagamentos pagamento);
    }
}
