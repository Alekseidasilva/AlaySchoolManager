namespace ALAYSchoolManager.Infra.CrossCutting.Extensions;

public static class BooleanExtensions
{
    public static string ConverterBoleanoParaString(this bool str)
    {
        if (str)
            return "Activado";
        else
            return "Desativado";
    }
    public static Boolean ConverterStringParaBoleano(this string str)
    {
        if (str == "Activado")
            return true;
        return false;
    }
}