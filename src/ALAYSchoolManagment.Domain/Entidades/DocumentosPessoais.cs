using ALAYSchoolManager.Domain.Entidades.Shared;

namespace ALAYSchoolManager.Domain.Entidades;

public class DocumentosPessoais : EntidadeBase
{
    public Pessoa DocumentoPessoaId { get; set; }

    public string DocumentoDesignacao { get; set; }
    public DocumentoPessoaisTipos DocumentoTipoId { get; set; }


    public override bool EstaConsistente()
    {
        throw new NotImplementedException();
    }
}