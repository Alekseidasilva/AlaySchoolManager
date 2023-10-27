

using ALAYSchoolManager.Domain.Entidades;

namespace ALAYSchoolManager.Domain.Interfaces.Repository.Shared
{
    public interface IAlunoEmolumentosRepository : IBaseSharedRepository<AlunoEmolumentos>
    {
        void Adicionar(AlunoEmolumentos alunoEmolumentos);
        void Remover(AlunoEmolumentos alunoEmolumentos);
        List<AlunoEmolumentos> ListarAlunoEmolmentos(long alunoNMatricula);
    }
}
