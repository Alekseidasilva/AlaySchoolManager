using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Infra.Data.Context;

namespace ALAYSchoolManagment.Infra.Data.Repository;

public class ContactoRepository : BaseRepository<Contactos>, IContactoRepository
{
    public ContactoRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }

}