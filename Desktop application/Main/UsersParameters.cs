using CardonerSistemas.Framework.Base;

namespace CSMaps
{
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
            Models.UsuarioParametro parametro = Get(idParametro);

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
            Models.UsuarioParametro parametro = Get(idParametro);

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
            Models.UsuarioParametro parametro = Get(idParametro);

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
            Models.UsuarioParametro parametro = Get(idParametro);

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
            Models.UsuarioParametro parametro = Get(idParametro);

            if (parametro == null || parametro.NumeroDecimal == null)
            {
                return defaultValue;
            }
            else
            {
                return parametro.NumeroDecimal;
            }
        }

        internal static System.DateTime? GetDateTime(ParametersId idParametro, System.DateTime? defaultValue = null)
        {
            Models.UsuarioParametro parametro = Get(idParametro);

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
            Models.UsuarioParametro parametro = Get(idParametro);

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
}