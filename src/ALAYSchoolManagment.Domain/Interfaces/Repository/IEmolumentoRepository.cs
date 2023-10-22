using ALAYSchoolManagment.Domain.Entidades;

namespace ALAYSchoolManagment.Domain.Interfaces.Repository
{
    public interface IEmolumentoRepository : IBaseRepository<Emolumentos>
    {
        IEnumerable<Emolumentos> ObterEmolumentosObrigatorios(int moduloId, int factorId);
        IEnumerable<Emolumentos> ObterEmolumentosOpcionais(int moduloId, int factorId);

    }
}
