namespace ALAYSchoolManagment.Infra.CrossCutting.Extensions;

public static class DateTimeExtensions
{
    //public static string ConverterDateTimeParaString(this DateTime strIn, string masc)
    //{
    //    return string.Format(CultureInfo.GetCultureInfo("pt-Br"), masc, strIn);
    //}
    public static string ConverterData(this DateTime value)
    {
        return value.ToString("dd-MM-yyyy");
    }

    public static string ConverterDataHora(this DateTime value)
    {
        return value.ToString("dd/MM/yyyy HH:mm");
    }
    public static string ConverterDataDiaSemana(this DateTime value)
    {
        return value.ToString("dddd, dd-MMMM-yyyy");
    }
    public static string ConverterDataHoraDiaSemana(this DateTime value)
    {
        return value.ToString("dddd, dd-MM-yyyy HH:mm:ss");
    }
    public static string ConverterDataHoraDiaSemanaMes(this DateTime value)
    {
        return value.ToString("dddd, dd-MMMM-yyyy HH:mm:ss");
    }
    public static string ConverterHora(this DateTime dataHora)
    {
        return string.Format("HH:mm:ss", dataHora);
    }










    //public static string ConverterStringParaDateTime(this DateTime? strIn, string masc)
    //{
    //    string retorno = String.Empty;
    //    if (strIn != null)
    //    {
    //        return string.Format(CultureInfo.GetCultureInfo("pt-Br"), masc, strIn);
    //    }
    //    return retorno;
    //}

}