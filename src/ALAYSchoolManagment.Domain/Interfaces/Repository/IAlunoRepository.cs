using ALAYSchoolManager.Domain.Entidades;

namespace ALAYSchoolManager.Domain.Interfaces.Repository;

public interface IAlunoRepository : IBaseRepository<Aluno>
{
    IEnumerable<Aluno> ObterTodosPorModulo(int moduloId);

    Int64 UltimoNumeroMatricula();

    Aluno? BuscarPeloNMatricula(string? nMatricula);
}