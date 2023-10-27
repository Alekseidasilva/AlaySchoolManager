using ALAYSchoolManager.Domain.Entidades;

namespace ALAYSchoolManager.Domain.Interfaces.Services.Shared
{
    public interface IAlunoEmolumentosService : IBaseSharedService<AlunoEmolumentos>
    {
        void Adicionar(AlunoEmolumentos alunoEmolumentos);
        void Remover(AlunoEmolumentos alunoEmolumentos);
        List<AlunoEmolumentos> ListarAlunoEmolmentos(long alunoNMatricula);
    }
}
