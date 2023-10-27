using ALAYSchoolManager.Domain.Entidades.Shared;

namespace ALAYSchoolManager.Domain.Entidades;

public class Departamentos : EntidadeBase
{
    public string DepartamentoDesignacao { get; set; }
    public override bool EstaConsistente()
    {
        throw new NotImplementedException();
    }
}