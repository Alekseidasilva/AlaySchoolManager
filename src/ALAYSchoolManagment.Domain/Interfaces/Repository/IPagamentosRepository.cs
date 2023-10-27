using ALAYSchoolManager.Domain.Entidades;

namespace ALAYSchoolManager.Domain.Interfaces.Repository
{
    public interface IPagamentosRepository : IBaseRepository<Pagamentos>
    {
        void EfectuarPagamento(Pagamentos pagamentos);
    }
}
