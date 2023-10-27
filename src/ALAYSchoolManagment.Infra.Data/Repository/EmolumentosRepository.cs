using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository
{
    public class EmolumentosRepository : BaseRepository<Emolumentos>, IEmolumentoRepository
    {
        public EmolumentosRepository(AlaySchoolGetDbContext context) : base(context)
        {
        }
        public IEnumerable<Emolumentos> ObterEmolumentosObrigatorios(int moduloId, int factorId)
        {
            //var emolumentos = (from emol in _db.Emolumentos
            //                   join mod in _db.Modulos on emol.Modulos.ModuloId equals mod.ModuloId
            //                   join fact in _db.EmolumentosFatores on emol.EmolumentoFatores.EmolumentoFatorId equals fact
            //                       .EmolumentoFatorId
            //                   where mod.ModuloId.Equals(moduloId) && fact.EmolumentoFatorId.Equals(factorId)
            //                   select new { emol, mod, fact, });
            List<Emolumentos> emolumentosList = new List<Emolumentos>();
            //foreach (var emol in emolumentos)
            //{
            //    var emo = new Emolumentos
            //    {
            //        EmolumentoDesignacao = emol.emol.EmolumentoDesignacao,
            //        EmolumentoPreco = emol.emol.EmolumentoPreco,
            //        Modulos = emol.mod,
            //        EmolumentoFatores = emol.fact,
            //        Id = emol.emol.Id
            //    };
            //    emolumentosList.Add(emo);
            //}
            return emolumentosList;
        }

        public IEnumerable<Emolumentos> ObterEmolumentosOpcionais(int moduloId, int factorId)
        {
            //var emolumentos = (from emol in _db.Emolumentos
            //                   join mod in _db.Modulos on emol.Modulos.ModuloId equals mod.ModuloId
            //                   join fact in _db.EmolumentosFatores on emol.EmolumentoFatores.EmolumentoFatorId equals fact
            //                       .EmolumentoFatorId
            //                   where mod.ModuloId.Equals(moduloId) && fact.EmolumentoFatorId.Equals(factorId)
            //                   select new { emol, mod, fact, });
            List<Emolumentos> emolumentosList = new List<Emolumentos>();
            //foreach (var emol in emolumentos)
            //{
            //    var emo = new Emolumentos
            //    {
            //        EmolumentoDesignacao = emol.emol.EmolumentoDesignacao,
            //        EmolumentoPreco = emol.emol.EmolumentoPreco,
            //        Modulos = emol.mod,
            //        EmolumentoFatores = emol.fact,
            //        Id = emol.emol.Id
            //    };
            //    emolumentosList.Add(emo);
            //}
            return emolumentosList;
        }
    }
}
