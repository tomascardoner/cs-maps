namespace CSMaps.Main;

internal static class Parameters
{
    internal enum ParametersId : short
    {
        // Sistema
        ApplicationDatabaseGuid = 1,
        LicensedCompany = 2,
        UsuarioNombreLongitudMinima = 3,
        UsuarioPasswordLongitudMinima = 4,
    }

    internal static bool LoadFromDatabase()
    {
        try
        {
            using Models.CSMapsContext context = new();
            Program.Parametros = [.. context.Parametro];
            return true;
        }
        catch (Exception ex)
        {
            if (ex.InnerException is not null && ex.InnerException.HResult == -2146232060)
            {
                MessageBox.Show("No se encontró la base de datos.", Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CardonerSistemas.Framework.Base.Error.ProcessException(ex, "Error al leer los parámetros desde la base de datos.");
            }

            return false;
        }
    }

    private static Models.Parametro Get(ParametersId idParametro)
    {
        return Program.Parametros.Find(p => p.IdParametro == (short)idParametro);
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