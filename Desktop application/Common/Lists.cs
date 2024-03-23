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

            List<Models.Entidad> entidades = [.. context.Entidades.OrderBy(e => e.Nombre)];

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

        static internal void GetEstablecimientos(ComboBox comboBox, Models.CSMapsContext context, bool showNotSpecified)
        {
            comboBox.ValueMember = "IdEstablecimiento";
            comboBox.DisplayMember = "Nombre";

            List<Models.Establecimiento> establecimientos = [.. context.Establecimientos.OrderBy(e => e.Nombre)];

            if (showNotSpecified)
            {
                Models.Establecimiento noEspecifica = new()
                {
                    IdEstablecimiento = CardonerSistemas.Framework.Base.Constants.ShortFieldValueNotSpecified,
                    Nombre = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemNotSpecified + Properties.Resources.StringItemEndChar
                };
                establecimientos.Insert(0, noEspecifica);
            }

            comboBox.DataSource = establecimientos;
        }

        static internal void GetEventosTipos(ComboBox comboBox, Models.CSMapsContext context, bool showAll, bool showEmpty, bool showComplete)
        {
            comboBox.ValueMember = "IdEventoTipo";
            comboBox.DisplayMember = "Nombre";

            List<Models.EventoTipo> eventos = [.. context.EventoTipos.OrderBy(e => e.Nombre)];

            if (showEmpty)
            {
                Models.EventoTipo vacio = new()
                {
                    IdEventoTipo = CardonerSistemas.Framework.Base.Constants.ByteFieldValueNotSpecified,
                    Nombre = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemEmptyMale + Properties.Resources.StringItemEndChar
                };
                eventos.Insert(0, vacio);
            }

            if (showComplete)
            {
                Models.EventoTipo completo = new()
                {
                    IdEventoTipo = CardonerSistemas.Framework.Base.Constants.ByteFieldValueOther,
                    Nombre = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemCompleteMale + Properties.Resources.StringItemEndChar
                };
                eventos.Insert(0, completo);
            }

            if (showAll)
            {
                Models.EventoTipo todos = new()
                {
                    IdEventoTipo = CardonerSistemas.Framework.Base.Constants.ByteFieldValueAll,
                    Nombre = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemAllMale + Properties.Resources.StringItemEndChar
                };
                eventos.Insert(0, todos);
            }

            comboBox.DataSource = eventos;
        }

    }
}
