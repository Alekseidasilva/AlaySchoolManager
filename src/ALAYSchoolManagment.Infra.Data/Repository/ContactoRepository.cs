using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository;

public class ContactoRepository : BaseRepository<Contactos>, IContactoRepository
{
    public ContactoRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }

}