using System.Globalization;

namespace ALAYSchoolManager.Infra.CrossCutting.Extensions;

public static class DecimalExtensions
{
    public static string ConverterDecimalParaString(this decimal strIn)
    {
        //return string.Format(CultureInfo.GetCultureInfo("pt-ao"), masc, strIn);
        return string.Format(CultureInfo.GetCultureInfo("pt-ao"), "{0:N}"); //0:0.00
    }
}