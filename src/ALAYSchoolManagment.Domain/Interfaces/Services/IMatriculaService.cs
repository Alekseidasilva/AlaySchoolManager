using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Services.Shared;

namespace ALAYSchoolManagment.Domain.Interfaces.Services;

public interface IMatriculaService : IBaseSharedService<Matriculas>
{
    string EfectuarMatricula(Matriculas matricula);
}