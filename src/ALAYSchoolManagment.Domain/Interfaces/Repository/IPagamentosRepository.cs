using ALAYSchoolManagment.Domain.Entidades;

namespace ALAYSchoolManagment.Domain.Interfaces.Repository
{
    public interface IPagamentosRepository : IBaseRepository<Pagamentos>
    {
        void EfectuarPagamento(Pagamentos pagamentos);
    }
}
