namespace ALAYSchoolManager.Infra.CrossCutting.Extensions;

public static class IntExtensions
{
    public static int ConverterStringParaInt(this string value)
    {
        return Int32.Parse(value);
    }
}