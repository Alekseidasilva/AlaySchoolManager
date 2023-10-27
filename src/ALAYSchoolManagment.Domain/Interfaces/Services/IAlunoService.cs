using ALAYSchoolManager.Domain.Entidades;

namespace ALAYSchoolManager.Domain.Interfaces.Services;

public interface IAlunoService : IBaseService<Aluno>
{
    Aluno? BuscarPeloNMatricula(string? nMatricula);
}