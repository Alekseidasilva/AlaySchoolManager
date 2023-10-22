using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Infra.Data.Context;

namespace ALAYSchoolManagment.Infra.Data.Repository;

public class DocumentoPessoaRepository : BaseRepository<DocumentosPessoais>, IDocumentosPessoaisRepository
{
    public DocumentoPessoaRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
}