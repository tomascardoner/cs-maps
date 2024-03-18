namespace CSMaps.Common
{
    internal static class Lists
    {
        static internal void GetAllYesNo(ComboBox comboBox, int selectElementNumber = -1)
        {
            comboBox.Items.AddRange(new string[] { Properties.Resources.StringItemStartChar + Properties.Resources.StringItemAllMale + Properties.Resources.StringItemEndChar, Properties.Resources.StringYes, Properties.Resources.StringNo });
            if (selectElementNumber > -1)
            {
                comboBox.SelectedIndex = selectElementNumber;
            }
        }

        static internal void GetEntidades(ComboBox comboBox, Models.CSMapsContext context, bool showNotSpecified)
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
