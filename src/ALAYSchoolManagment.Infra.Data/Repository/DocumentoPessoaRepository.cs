using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository;

public class DocumentoPessoaRepository : BaseRepository<DocumentosPessoais>, IDocumentosPessoaisRepository
{
    public DocumentoPessoaRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
}