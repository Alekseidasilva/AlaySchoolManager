using ALAYSchoolManagment.Infra.Data.Context;

namespace ALAYSchoolManagment.Infra.CrossCutting.Helpers;

public static class GerarNumeroMatricula
{
    private static readonly AlaySchoolGetDbContext? _db;





    public static Int64 GerarNumero(Int64 ultimoNumero)
   => ultimoNumero + 1;



    public static string NumeroCompleto(Int64 numeroMatricula)
    {
        string numero = String.Empty;
        switch (numeroMatricula)
        {
            case < 10:
                numero = "000" + numeroMatricula.ToString();
                break;
            case < 100:
                numero = "00" + numeroMatricula.ToString();
                break;
            case > 1000:
                numero = numeroMatricula.ToString();
                break;
        }
        return numero;
    }

}