using CardonerSistemas.Framework.Base;

namespace CSMaps.Main;

internal static class UsersParameters
{
    internal enum ParametersId : short
    {
        // System parameters
    }

    internal static bool LoadFromDatabase()
    {
        try
        {
            using Models.CSMapsContext context = new();
            Program.ParametrosUsuario = [.. context.UsuarioParametros];
            return true;
        }
        catch (Exception ex)
        {
            Program.ParametrosUsuario = [];
            Error.ProcessException(ex, "Error al leer los parámetros del usuario desde la base de datos.");
            return false;
        }
    }

    private static Models.UsuarioParametro Get(ParametersId idParametro)
    {
        return Program.ParametrosUsuario.Find(p => p.IdParametro == (short)idParametro);
    }

    internal static string GetText(ParametersId idParametro, string defaultValue = null)
    {
        var parametro = Get(idParametro);

        return parametro == null || parametro.Texto == null ? defaultValue : parametro.Texto;
    }

    internal static byte? GetIntegerAsByte(ParametersId idParametro, byte? defaultValue = null)
    {
        var parametro = Get(idParametro);

        return parametro == null || parametro.NumeroEntero == null ? defaultValue : (byte)parametro.NumeroEntero;
    }

    internal static short? GetIntegerAsShort(ParametersId idParametro, short? defaultValue = null)
    {
        var parametro = Get(idParametro);

        return parametro == null || parametro.NumeroEntero == null ? defaultValue : (short)parametro.NumeroEntero;
    }

    internal static int? GetIntegerAsInt(ParametersId idParametro, int? defaultValue = null)
    {
        var parametro = Get(idParametro);

        return parametro == null || parametro.NumeroEntero == null ? defaultValue : parametro.NumeroEntero;
    }

    internal static decimal? GetDecimal(ParametersId idParametro, decimal? defaultValue = null)
    {
        var parametro = Get(idParametro);

        return parametro == null || parametro.NumeroDecimal == null ? defaultValue : parametro.NumeroDecimal;
    }

    internal static DateTime? GetDateTime(ParametersId idParametro, DateTime? defaultValue = null)
    {
        var parametro = Get(idParametro);

        return parametro == null || parametro.FechaHora == null ? defaultValue : parametro.FechaHora;
    }

    internal static bool? GetBool(ParametersId idParametro, bool? defaultValue = null)
    {
        var parametro = Get(idParametro);

        return parametro == null || parametro.SiNo == null ? defaultValue : parametro.SiNo;
    }
}