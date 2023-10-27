using ALAYSchoolManager.Domain.Entidades.Vo;
using ALAYSchoolManager.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManager.Domain.Interfaces.Services.Shared;

namespace ALAYSchoolManager.Domain.Services.Shared;

public class EstadoCivilService : IEstadoCivilService
{
    private readonly IEstadoCivilRepository _estadoCivilRepository;

    public EstadoCivilService(IEstadoCivilRepository estadoCivilRepository)
    {
        _estadoCivilRepository = estadoCivilRepository;
    }

    public EstadoCivilVo? ObterPorId(int id)
    {
        return _estadoCivilRepository.ObterPorId(id);
    }

    public IEnumerable<EstadoCivilVo> ObterTodos()
    {
        return _estadoCivilRepository.ObterTodos();
    }

    public void Dispose()
    {
        _estadoCivilRepository.Dispose();
        GC.SuppressFinalize(this);
    }
}