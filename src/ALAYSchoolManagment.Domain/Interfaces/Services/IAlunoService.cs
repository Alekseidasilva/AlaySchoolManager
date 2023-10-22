using ALAYSchoolManagment.Domain.Entidades;

namespace ALAYSchoolManagment.Domain.Interfaces.Services;

public interface IAlunoService : IBaseService<Aluno>
{
    Aluno? BuscarPeloNMatricula(string? nMatricula);
}