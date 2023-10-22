using ALAYSchoolManagment.Domain.Entidades;

namespace ALAYSchoolManagment.Domain.Interfaces.Services
{
    public interface IPagamentosService : IBaseService<Pagamentos>
    {
        void EfectuarPagamento(Pagamentos pagamentos);
    }
}
