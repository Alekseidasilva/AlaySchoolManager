using ALAYSchoolManager.Domain.Entidades.Oldest.Shared;
using ALAYSchoolManager.Domain.Entidades.Shared;

namespace ALAYSchoolManager.Domain.Entidades;

public class Contactos : EntidadeBase
{
    public string ContactoDesignacao { get; set; }
    public Pessoa ContactoPessoaId { get; set; }
    public ContactosTipos ContactoTipoId { get; set; }
    public ContactoParente ContactoParenteId { get; set; }

    public override bool EstaConsistente()
    {
        throw new NotImplementedException();
    }
}