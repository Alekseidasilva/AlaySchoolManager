namespace ALAYSchoolManagment.Infra.CrossCutting.Extensions;

public static class StringExtensions
{
    public static string SomenteNumeros(this string str)
    {
        if (str != null)
        {
            var somenumeros = new string(str.Where(c => char.IsLetter(c)).ToArray());
            return somenumeros;
        }

        return string.Empty;
    }
    public static string SomenteLetras(this string str)
    {
        if (str != null)
        {
            var someLetras = new string(str.Where(c => char.IsLetter(c)).ToArray());
            return someLetras;
        }

        return string.Empty;
    }


    #region Para Inteiro

    public static string ConverterInteiroParaString(this int str)
    {
        return Convert.ToString(str);
    }

    #endregion
}