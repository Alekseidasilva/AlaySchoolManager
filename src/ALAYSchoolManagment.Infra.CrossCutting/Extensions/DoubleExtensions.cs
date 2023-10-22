namespace ALAYSchoolManagment.Infra.CrossCutting.Extensions;

public static class DoubleExtensions
{
    public static string ConverterDoubleParaString(this double strIn)
    {
        return strIn.ToString("N");
        //return string.Format(CultureInfo.GetCultureInfo("pt-ao"), "{0:N}");

    }
}