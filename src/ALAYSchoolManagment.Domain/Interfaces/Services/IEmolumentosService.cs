using ALAYSchoolManagment.Domain.Entidades;

namespace ALAYSchoolManagment.Domain.Interfaces.Services
{
    public interface IEmolumentosService : IBaseService<Emolumentos>
    {
        IEnumerable<Emolumentos> ObterEmolumentosObrigatorios(int moduloId, int factorId);
        IEnumerable<Emolumentos> ObterEmolumentosOpcionais(int moduloId, int factorId);

    }
}
