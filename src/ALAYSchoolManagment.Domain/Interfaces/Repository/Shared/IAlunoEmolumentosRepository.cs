

using ALAYSchoolManagment.Domain.Entidades;

namespace ALAYSchoolManagment.Domain.Interfaces.Repository.Shared
{
    public interface IAlunoEmolumentosRepository : IBaseSharedRepository<AlunoEmolumentos>
    {
        void Adicionar(AlunoEmolumentos alunoEmolumentos);
        void Remover(AlunoEmolumentos alunoEmolumentos);
        List<AlunoEmolumentos> ListarAlunoEmolmentos(long alunoNMatricula);
    }
}
