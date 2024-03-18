namespace CSMaps.Common
{
    internal static class Lists
    {
        static internal void ObtenerEntidades(ComboBox comboBox, Models.CSMapsContext context, bool showNotSpecified)
        {
            comboBox.ValueMember = "IdEntidad";
            comboBox.DisplayMember = "Nombre";

            List<Models.Entidad> entidades = [.. context.Entidads.OrderBy(e => e.Nombre)];

            if (showNotSpecified)
            {
                Models.Entidad noEspecifica = new()
                {
                    IdEntidad = CardonerSistemas.Framework.Base.Constants.ShortFieldValueNotSpecified,
                    Nombre = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemNotSpecified + Properties.Resources.StringItemEndChar
                };
                entidades.Insert(0, noEspecifica);
            }

            comboBox.DataSource = entidades;
        }
    }
}
