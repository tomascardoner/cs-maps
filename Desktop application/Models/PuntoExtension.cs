namespace CSMaps.Models
{
    public partial class Punto
    {
        public string NombreExportar => PuntoDato == null ? Nombre : PuntoDato.ChapaNumero.ToString();
#pragma warning disable CA1822 // Mark members as static
        public string ComentarioExportar => string.Empty;
#pragma warning restore CA1822 // Mark members as static
        public string DescripcionExportar
        {
            get
            {
                if (PuntoDato == null)
                {
                    return string.Empty;
                }
                else
                {
                    string value = string.Empty;
                    if (PuntoDato.IdEstablecimiento.HasValue)
                    {
                        // Nombre del establecimiento
                        value = PuntoDato.IdEstablecimientoNavigation.Nombre;
                        if (!string.IsNullOrWhiteSpace(PuntoDato.IdEstablecimientoNavigation.TelefonoMovil))
                        {
                            // Teléfono del establecimiento
                            value += $"\n{PuntoDato.IdEstablecimientoNavigation.TelefonoMovil}";
                        }
                        if (PuntoDato.IdEstablecimientoNavigation.IdEntidad.HasValue)
                        {
                            if (string.Compare(PuntoDato.IdEstablecimientoNavigation.Nombre, PuntoDato.IdEstablecimientoNavigation.IdEntidadNavigation.Nombre) != 0)
                            {
                                // Nombre de la entidad, si es diferente al del establecimiento
                                value += $"\n{PuntoDato.IdEstablecimientoNavigation.IdEntidadNavigation.Nombre}";
                            }
                            if (!string.IsNullOrWhiteSpace(PuntoDato.IdEstablecimientoNavigation.IdEntidadNavigation.TelefonoMovil) && string.Compare(PuntoDato.IdEstablecimientoNavigation.TelefonoMovil, PuntoDato.IdEstablecimientoNavigation.IdEntidadNavigation.TelefonoMovil) != 0)
                            {
                                // Teléfono de la entidad, si es diferente al del establecimiento
                                value += $"\n{PuntoDato.IdEstablecimientoNavigation.IdEntidadNavigation.TelefonoMovil}";
                            }
                        }
                    }
                    return value;
                }
            }
        }
        public string TelefonoMovilExportar
        {
            get
            {
                if (PuntoDato == null)
                {
                    return string.Empty;
                }
                else
                {
                    if (PuntoDato.IdEstablecimiento.HasValue)
                    {
                        if (!string.IsNullOrWhiteSpace(PuntoDato.IdEstablecimientoNavigation.TelefonoMovil))
                        {
                            // Teléfono del establecimiento
                            return PuntoDato.IdEstablecimientoNavigation.TelefonoMovil;
                        }
                        if (PuntoDato.IdEstablecimientoNavigation.IdEntidad.HasValue && !string.IsNullOrWhiteSpace(PuntoDato.IdEstablecimientoNavigation.IdEntidadNavigation.TelefonoMovil))
                        {
                            // Teléfono de la entidad
                            return PuntoDato.IdEstablecimientoNavigation.IdEntidadNavigation.TelefonoMovil;
                        }
                    }
                    return string.Empty;
                }
            }
        }
    }
}