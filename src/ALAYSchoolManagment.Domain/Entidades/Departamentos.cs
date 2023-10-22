using ALAYSchoolManagment.Domain.Entidades.Shared;

namespace ALAYSchoolManagment.Domain.Entidades;

public class Departamentos : EntidadeBase
{
    public string DepartamentoDesignacao { get; set; }
    public override bool EstaConsistente()
    {
        throw new NotImplementedException();
    }
}