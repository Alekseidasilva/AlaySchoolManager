using ALAYSchoolManager.Domain.Entidades;

namespace ALAYSchoolManager.Domain.Interfaces.Repository
{
    public interface IEmolumentoRepository : IBaseRepository<Emolumentos>
    {
        IEnumerable<Emolumentos> ObterEmolumentosObrigatorios(int moduloId, int factorId);
        IEnumerable<Emolumentos> ObterEmolumentosOpcionais(int moduloId, int factorId);

    }
}
