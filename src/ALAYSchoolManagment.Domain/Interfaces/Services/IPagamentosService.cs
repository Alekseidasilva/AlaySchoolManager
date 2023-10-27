using ALAYSchoolManager.Domain.Entidades;

namespace ALAYSchoolManager.Domain.Interfaces.Services
{
    public interface IPagamentosService : IBaseService<Pagamentos>
    {
        void EfectuarPagamento(Pagamentos pagamentos);
    }
}
