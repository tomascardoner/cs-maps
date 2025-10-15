namespace CSMaps;

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
            Program.Parametros = [.. context.Parametros];
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
        if (parametro == null || parametro.Texto == null)
        {
            return defaultValue;
        }
        else
        {
            return parametro.Texto;
        }
    }

    internal static byte? GetIntegerAsByte(ParametersId idParametro, byte? defaultValue = null)
    {
        var parametro = Get(idParametro);
        if (parametro == null || parametro.NumeroEntero == null)
        {
            return defaultValue;
        }
        else
        {
            return (byte)parametro.NumeroEntero;
        }
    }

    internal static short? GetIntegerAsShort(ParametersId idParametro, short? defaultValue = null)
    {
        var parametro = Get(idParametro);
        if (parametro == null || parametro.NumeroEntero == null)
        {
            return defaultValue;
        }
        else
        {
            return (short)parametro.NumeroEntero;
        }
    }

    internal static int? GetIntegerAsInt(ParametersId idParametro, int? defaultValue = null)
    {
        var parametro = Get(idParametro);
        if (parametro == null || parametro.NumeroEntero == null)
        {
            return defaultValue;
        }
        else
        {
            return parametro.NumeroEntero;
        }
    }

    internal static decimal? GetDecimal(ParametersId idParametro, decimal? defaultValue = null)
    {
        var parametro = Get(idParametro);
        if (parametro == null || parametro.NumeroDecimal == null)
        {
            return defaultValue;
        }
        else
        {
            return parametro.NumeroDecimal;
        }
    }

    internal static DateTime? GetDateTime(ParametersId idParametro, DateTime? defaultValue = null)
    {
        var parametro = Get(idParametro);
        if (parametro == null || parametro.FechaHora == null)
        {
            return defaultValue;
        }
        else
        {
            return parametro.FechaHora;
        }
    }

    internal static bool? GetBool(ParametersId idParametro, bool? defaultValue = null)
    {
        var parametro = Get(idParametro);
        if (parametro == null || parametro.SiNo == null)
        {
            return defaultValue;
        }
        else
        {
            return parametro.SiNo;
        }
    }
}