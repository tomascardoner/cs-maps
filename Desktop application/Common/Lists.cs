using CSMaps.Main;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CSMaps.Common;

internal static class Lists
{
    internal static void GetAllYesNo(ComboBox comboBox, int selectElementNumber = -1)
    {
        comboBox.Items.AddRange(Properties.Resources.StringItemStartChar + Properties.Resources.StringItemAllMale + Properties.Resources.StringItemEndChar, Properties.Resources.StringYes, Properties.Resources.StringNo);
        comboBox.SelectedIndex = selectElementNumber;
    }

    internal static void GetGenders(ComboBox comboBox, bool mostrarNoEspecifica)
    {
        const string idFieldName = "IdGenero";
        const string nombreFieldName = "Nombre";

        DataTable dataTable = new("Generos");
        DataRow dataRow;

        comboBox.ValueMember = idFieldName;
        comboBox.DisplayMember = nombreFieldName;

        dataTable.Columns.Add(idFieldName, Type.GetType("System.String"));
        dataTable.Columns.Add(nombreFieldName, Type.GetType("System.String"));

        if (mostrarNoEspecifica)
        {
            dataRow = dataTable.NewRow();
            dataRow[idFieldName] = Constants.GenderUnknown;
            dataRow[nombreFieldName] = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemNotSpecified + Properties.Resources.StringItemEndChar;
            dataTable.Rows.Add(dataRow);
        }

        dataRow = dataTable.NewRow();
        dataRow[idFieldName] = Constants.GenderMale;
        dataRow[nombreFieldName] = Properties.Resources.StringGenderMale;
        dataTable.Rows.Add(dataRow);

        dataRow = dataTable.NewRow();
        dataRow[idFieldName] = Constants.GenderFemale;
        dataRow[nombreFieldName] = Properties.Resources.StringGenderFemale;
        dataTable.Rows.Add(dataRow);

        comboBox.DataSource = dataTable;
        comboBox.SelectedIndex = mostrarNoEspecifica ? 0 : -1;
    }

    internal static void GetEntidades(ComboBox comboBox, Models.CSMapsContext dbContext, bool showAll, bool showNotSpecified)
    {
        comboBox.ValueMember = "IdEntidad";
        comboBox.DisplayMember = "Nombre";

        List<Models.Entidad> entidades = [.. dbContext.Entidad.OrderBy(e => e.Nombre)];

        if (showNotSpecified)
        {
            entidades.Insert(0, new Models.Entidad
            {
                IdEntidad = CardonerSistemas.Framework.Base.Constants.ShortFieldValueNotSpecified,
                Nombre = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemNotSpecified + Properties.Resources.StringItemEndChar
            });
        }

        if (showAll)
        {
            entidades.Insert(0, new Models.Entidad
            {
                IdEntidad = CardonerSistemas.Framework.Base.Constants.ShortFieldValueAll,
                Nombre = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemAllFemale + Properties.Resources.StringItemEndChar
            });
        }

        comboBox.DataSource = entidades;
    }

    internal static void GetEstablecimientos(ComboBox comboBox, Models.CSMapsContext context, bool showNotSpecified, bool showEntidad)
    {
        comboBox.ValueMember = "IdEstablecimiento";
        comboBox.DisplayMember = "Nombre";

        var establecimientos =
            context.Establecimiento.AsNoTracking()
                .LeftJoin(context.Entidad.AsNoTracking(), e => e.IdEntidad, en => en.IdEntidad, (e, en) => new { Establecimiento = e, Entidad = en })
                .OrderBy(e => e.Establecimiento.Nombre)
                .ThenBy(e => e.Entidad.Nombre)
                .Select(e => new
                {
                    IdEstablecimiento = e.Establecimiento.IdEstablecimiento,
                    Nombre = e.Establecimiento.Nombre + (showEntidad && e.Entidad != null ? " (" + e.Entidad.Nombre + ")" : string.Empty)
                }).ToList();

        if (showNotSpecified)
        {
            establecimientos.Insert(0, new
            {
                IdEstablecimiento = CardonerSistemas.Framework.Base.Constants.ShortFieldValueNotSpecified,
                Nombre = Properties.Resources.StringItemStartChar + Properties.Resources.StringItemNotSpecified + Properties.Resources.StringItemEndChar
            });
        }

        comboBox.DataSource = establecimientos;
    }

    internal static void GetEventosTipos(ComboBox comboBox, Models.CSMapsContext context, bool showAll, bool showEmpty, bool showComplete)
    {
        comboBox.ValueMember = "IdEventoTipo";
        comboBox.DisplayMember = "Nombre";

        List<Models.EventoTipo> eventos = [.. context.EventoTipo.OrderBy(e => e.Orden).ThenBy(e => e.Nombre)];

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

        usuarioGrupos = [.. context.UsuarioGrupo.Where(ug => (showInactives || ug.EsActivo) && (showAdministrators || ug.IdUsuarioGrupo != Constants.UserGroupAdministratorsId)).OrderBy(ug => ug.Nombre)];

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
        List<Models.Grupo> grupos = [.. context.Grupo.Where(g => g.EsActivo).OrderBy(g => g.Nombre)];

        listBox.DataSource = grupos;
        listBox.ValueMember = "IdGrupo";
        listBox.DisplayMember = "Nombre";
    }
}
