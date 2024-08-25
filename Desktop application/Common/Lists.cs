using System.Data;

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

        static internal void GetGenders(ComboBox comboBox, bool mostrarNoEspecifica)
        {
            const string IdFieldName = "IdGenero";
            const string NombreFieldName = "Nombre";

            DataTable dataTable = new("Generos");
            DataRow dataRow;

            comboBox.ValueMember = IdFieldName;
            comboBox.DisplayMember = NombreFieldName;

            dataTable.Columns.Add(IdFieldName, System.Type.GetType("System.String"));
            dataTable.Columns.Add(NombreFieldName, System.Type.GetType("System.String"));

            if (mostrarNoEspecifica)
            {
                dataRow = dataTable.NewRow();
                dataRow[IdFieldName] = Constants.GenderUnknown;
                dataRow[NombreFieldName] = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemNotSpecified + Properties.Resources.StringItemEndChar;
                dataTable.Rows.Add(dataRow);
            }

            dataRow = dataTable.NewRow();
            dataRow[IdFieldName] = Constants.GenderMale;
            dataRow[NombreFieldName] = Properties.Resources.StringGenderMale;
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow[IdFieldName] = Constants.GenderFemale;
            dataRow[NombreFieldName] = Properties.Resources.StringGenderFemale;
            dataTable.Rows.Add(dataRow);

            comboBox.DataSource = dataTable;
            if (mostrarNoEspecifica)
            {
                comboBox.SelectedIndex = 0;
            }
            else
            {
                comboBox.SelectedIndex = -1;
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

            List<Models.EventoTipo> eventos = [.. context.EventoTipos.OrderBy(e => e.Orden).ThenBy(e => e.Nombre)];

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

        internal static void GetUsersGroups(ComboBox comboBox, Models.CSMapsContext context, bool showNotSpecified, bool showAll, bool showInactives = false, bool showAdministrators = true)
        {
            List<Models.UsuarioGrupo> usuarioGrupos;

            comboBox.ValueMember = "IdUsuarioGrupo";
            comboBox.DisplayMember = "Nombre";

            usuarioGrupos = [.. context.UsuarioGrupos.Where(ug => (showInactives || ug.EsActivo) && (showAdministrators || ug.IdUsuarioGrupo != Constants.UserGroupAdministratorsId)).OrderBy(ug => ug.Nombre)];

            if (showNotSpecified)
            {
                Models.UsuarioGrupo noEspecifica = new()
                {
                    IdUsuarioGrupo = CardonerSistemas.Framework.Base.Constants.ByteFieldValueNotSpecified,
                    Nombre = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemNotSpecified + Properties.Resources.StringItemEndChar
                };
                usuarioGrupos.Insert(0, noEspecifica);
            }

            if (showAll)
            {
                Models.UsuarioGrupo todos = new()
                {
                    IdUsuarioGrupo = CardonerSistemas.Framework.Base.Constants.ByteFieldValueAll,
                    Nombre = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemAllMale + Properties.Resources.StringItemEndChar
                };
                usuarioGrupos.Insert(0, todos);
            }

            comboBox.DataSource = usuarioGrupos;
        }

        internal static void GetGroups(ListBox listBox, Models.CSMapsContext context)
        {
            List<Models.Grupo> grupos = [..context.Grupos.Where(g => g.EsActivo).OrderBy(g => g.Nombre)];

            listBox.DataSource = grupos;
            listBox.ValueMember = "IdGrupo";
            listBox.DisplayMember = "Nombre";
        }
    }
}
