using ALAYSchoolManagment.Domain.Entidades;

namespace ALAYSchoolManagment.Domain.Interfaces.Repository;

public interface IAlunoRepository : IBaseRepository<Aluno>
{
    IEnumerable<Aluno> ObterTodosPorModulo(int moduloId);

    Int64 UltimoNumeroMatricula();

    Aluno? BuscarPeloNMatricula(string? nMatricula);
}