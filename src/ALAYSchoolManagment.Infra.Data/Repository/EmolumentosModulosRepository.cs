using System.Data;
using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Entidades.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Infra.Data.Context;

namespace ALAYSchoolManagment.Infra.Data.Repository;

public class EmolumentosModulosRepository : BaseRepository<EmolumentosModulos>, IEmolumentosModulosRepository
{
    public EmolumentosModulosRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }

    public override IEnumerable<EmolumentosModulos> ObterTodos()
    {
        _ado.LimparParametro();
        DataTable EmoMod = _ado.ExecutarConsulta(CommandType.StoredProcedure, "uspEmolumentosModulosListar");
        List<EmolumentosModulos> list = new List<EmolumentosModulos>();
        foreach (DataRow linha in EmoMod.Rows)
        {
            var emoM = new EmolumentosModulos
            {
                EmolumentoModuloEmolumentoId = new Emolumentos
                {
                    Id = Convert.ToInt16(linha["EmolumentoId"]),
                    EmolumentoDesignacao = Convert.ToString(linha["EmolumentoDesignacao"])
                },
                EmolumentoModuloFactorId = new EmolumentosFatores
                {
                    EmolumentoFatorId = Convert.ToInt16(linha["EmolumentoFactorId"]),
                    EmolumentoFatorDesignacao = Convert.ToString(linha["EmolumentoFactorDesignacao"])
                },
                EmolumentoModuloModuloId = new Modulos
                {
                    ModuloId = Convert.ToInt16(linha["ModuloId"]),
                    ModuloDesignacao = Convert.ToString(linha["ModuloDesignacao"])
                },
                EmolumentoModuloPreco = Convert.ToDecimal(linha["EmolumentoModuloPreco"]),
                UsuarioCadastrador = Convert.ToString(linha["EmolumentoModuloUsuarioCadastrador"]),
                EmolumentoModuloEstado = Convert.ToBoolean(linha["EmolumentoModuloEstado"])
            };
            list.Add(emoM);
        }

        return list;
    }
}