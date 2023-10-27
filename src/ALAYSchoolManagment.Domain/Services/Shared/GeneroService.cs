using ALAYSchoolManager.Domain.Entidades.Vo;
using ALAYSchoolManager.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManager.Domain.Interfaces.Services.Shared;

namespace ALAYSchoolManager.Domain.Services.Shared;

public class GeneroService : IGeneroService
{
    private readonly IGeneroRepository _generoRepository;

    public GeneroService(IGeneroRepository generoRepository)
    {
        _generoRepository = generoRepository;
    }

    public GenerosVo? ObterPorId(int id)
    {
        return _generoRepository.ObterPorId(id);
    }

    public IEnumerable<GenerosVo> ObterTodos()
    {
        return _generoRepository.ObterTodos();
    }

    public void Dispose()
    {
        _generoRepository.Dispose();
        GC.SuppressFinalize(this);
    }
}