using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;

namespace CSMaps.General
{
    public partial class FormPointEvents : Form
    {

        #region Declarations

        private const string entityNameSingle = "evento del punto";
        private const string entityNamePlural = "eventos del punto";
        private const bool entityIsFemale = false;

        private readonly int idPunto;
        private List<DataGridViewRowData> entitiesAll;
        private List<DataGridViewRowData> entitiesFiltered;

        private readonly Users.Permissions.Actions addPermission = Users.Permissions.Actions.PointEventAdd;
        private readonly Users.Permissions.Actions editPermission = Users.Permissions.Actions.PointEventEdit;
        private readonly Users.Permissions.Actions deletePermission = Users.Permissions.Actions.PointEventDelete;

        private ToolStripControlHost HostDateTimePickerDateFilterFrom;
        private ToolStripControlHost HostDateTimePickerDateFilterTo;

        private DataGridViewColumn sortedColumn;
        private SortOrder sortOrder;

        private bool skipFilterApply = true;

        public class DataGridViewRowData
        {
            public short IdEvento { get; set; }
            public byte IdEventoTipo { get; set; }
            public string EventoTipoNombre { get; set; }
            public System.DateTime FechaHora { get; set; }
        }

        #endregion

        #region Form stuff

        public FormPointEvents(int idPuntoOrigen)
        {
            InitializeComponent();

            idPunto = idPuntoOrigen;

            InitializeForm();
        }

        private void InitializeForm()
        {
            SetAppearance();

            InitializeDateFilter();
            DateAndTime.FillPeriodTypesComboBox(ToolStripComboBoxDateFilterPeriodType.ComboBox, DateAndTime.PeriodTypes.All);

            using Models.CSMapsContext context = new();
            SetDataToUserInterface(context);
            Common.Lists.GetEventosTipos(ToolStripComboBoxEventTypeFilter.ComboBox, context, true, false, false);

            // Set the initial sorted column of the grid
            sortedColumn = DataGridViewColumnFechaHora;
            sortOrder = SortOrder.Descending;

            skipFilterApply = false;
            ReadData();
        }

        private void SetAppearance()
        {
            Forms.SetFont(this, Program.AppearanceConfig.Font);
            Common.Appearance.SetControlsDataGridViews(this.Controls, true);
        }

        private void InitializeDateFilter()
        {
#pragma warning disable S6562 // Always set the "DateTimeKind" when creating new "DateTime" instances

            // Date from control
            DateTimePicker DateTimePickerDateFilterFrom = new()
            {
                Format = DateTimePickerFormat.Short,
                MinDate = new(2022, 1, 1),
                MaxDate = new(2099, 12, 31),
                Value = System.DateTime.Now,
                Width = 100
            };
            DateTimePickerDateFilterFrom.ValueChanged += DateTimePickerDateFilter_ValueChanged;
            HostDateTimePickerDateFilterFrom = new(DateTimePickerDateFilterFrom)
            {
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Visible = false,
                Width = 100
            };
            ToolStripDateFilter.Items.Insert(3, HostDateTimePickerDateFilterFrom);

            // Date to control
            DateTimePicker DateTimePickerDateFilterTo = new()
            {
                Format = DateTimePickerFormat.Short,
                MinDate = new(2022, 1, 1),
                MaxDate = new(2099, 12, 31),
                Value = System.DateTime.Now,
                Width = 100
            };
            DateTimePickerDateFilterTo.ValueChanged += DateTimePickerDateFilter_ValueChanged;
            HostDateTimePickerDateFilterTo = new(DateTimePickerDateFilterTo)
            {
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Visible = false,
                Width = 100
            };
            ToolStripDateFilter.Items.Add(HostDateTimePickerDateFilterTo);
#pragma warning restore S6562 // Always set the "DateTimeKind" when creating new "DateTime" instances
        }

        private void This_Load(object sender, EventArgs e)
        {
            sortedColumn.HeaderCell.SortGlyphDirection = sortOrder;
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            entitiesAll = null;
            entitiesFiltered = null;
            if (HostDateTimePickerDateFilterFrom != null)
            {
                HostDateTimePickerDateFilterFrom.Control.Dispose();
                HostDateTimePickerDateFilterFrom.Dispose();
                HostDateTimePickerDateFilterFrom = null;
            }
            if (HostDateTimePickerDateFilterTo != null)
            {
                HostDateTimePickerDateFilterTo.Control.Dispose();
                HostDateTimePickerDateFilterTo.Dispose();
                HostDateTimePickerDateFilterTo = null;
            }
        }

        #endregion

        #region User interface data

        private void SetDataToUserInterface(Models.CSMapsContext context)
        {
            Models.PuntoDato puntoDato = context.PuntoDatos.Find(idPunto);
            if (puntoDato.IdEstablecimiento.HasValue)
            {
                Models.Establecimiento establecimiento = context.Establecimientos.Find(puntoDato.IdEstablecimiento);
                TextBoxEstablecimiento.Text = establecimiento.Nombre;
            }
            else
            {
                TextBoxEstablecimiento.Text = string.Empty;
            }
            Values.ToTextBox(TextBoxChapaNumero, puntoDato.ChapaNumero);
        }

        internal void ReadData(short idEvento = 0, bool restoreCurrentPosition = false)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                entitiesAll = [.. from pe in context.PuntoEventos
                                  join e in context.EventoTipos on pe.IdEventoTipo equals e.IdEventoTipo into eventoTiposGrupo
                                  from etg in eventoTiposGrupo.DefaultIfEmpty()
                                  where pe.IdPunto == idPunto
                                  select new DataGridViewRowData { IdEvento = pe.IdEvento, IdEventoTipo = pe.IdEventoTipo, EventoTipoNombre = (etg == null ? string.Empty : etg.Nombre), FechaHora = pe.FechaHora }];
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Error.ProcessException(ex, Properties.Resources.StringDatabaseReadError);
                return;
            }

            // Save position
            if (restoreCurrentPosition)
            {
                if (DataGridViewMain.CurrentRow == null)
                {
                    idEvento = 0;
                }
                else
                {
                    idEvento = ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEvento;
                }
            }

            FilterData();

            // Restore position
            if (idEvento != 0)
            {
                foreach (DataGridViewRow row in DataGridViewMain.Rows)
                {
                    if (((DataGridViewRowData)row.DataBoundItem).IdEvento == idEvento)
                    {
                        DataGridViewMain.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }

        private void FilterData()
        {
            if (skipFilterApply)
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;


            // Date
            DateAndTime.GetDatesFromPeriodTypeAndValue((DateAndTime.PeriodTypes)ToolStripComboBoxDateFilterPeriodType.SelectedIndex, (byte)ToolStripComboBoxDateFilterPeriodValue.SelectedIndex, out System.DateTime fechaDesde, out System.DateTime fechaHasta, ((DateTimePicker)HostDateTimePickerDateFilterFrom.Control).Value, ((DateTimePicker)HostDateTimePickerDateFilterTo.Control).Value);
            entitiesFiltered = [.. entitiesAll.Where(pe => pe.FechaHora >= fechaDesde && pe.FechaHora <= fechaHasta)];

            // Event type
            if ((byte)ToolStripComboBoxEventTypeFilter.ComboBox.SelectedValue != CardonerSistemas.Framework.Base.Constants.ByteFieldValueAll)
            {
                entitiesFiltered = [.. entitiesFiltered.Where(pe => pe.IdEventoTipo == (byte)ToolStripComboBoxEventTypeFilter.ComboBox.SelectedValue)];
            }

            ToolStripLabelItemsCounter.Text = Common.DataGridViews.GetItemsCountText(entityNameSingle, entityNamePlural, entitiesFiltered.Count);

            OrderData();
        }

        private void OrderData()
        {
            if (sortedColumn == DataGridViewColumnFechaHora)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderBy(pe => pe.FechaHora)];
                }
                else
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderByDescending(pe => pe.FechaHora)];
                }
            }
            else if (sortedColumn == DataGridViewColumnEventoTipo)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderBy(pe => pe.EventoTipoNombre).ThenBy(pe => pe.FechaHora)];
                }
                else
                {
                    entitiesFiltered = [.. entitiesFiltered.OrderByDescending(pe => pe.EventoTipoNombre).ThenByDescending(pe => pe.FechaHora)];
                }
            }
            DataGridViewMain.AutoGenerateColumns = false;
            DataGridViewMain.DataSource = entitiesFiltered;
            sortedColumn.HeaderCell.SortGlyphDirection = sortOrder;
            this.Cursor = Cursors.Default;
        }

        #endregion

        #region Controls events

        private void ToolStripComboBoxDateFilterPeriodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateAndTime.FillPeriodValuesComboBox(ToolStripComboBoxDateFilterPeriodValue.ComboBox, (DateAndTime.PeriodTypes)ToolStripComboBoxDateFilterPeriodType.SelectedIndex);
        }

        private void ToolStripComboBoxDateFilterPeriodValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            HostDateTimePickerDateFilterFrom.Visible = (ToolStripComboBoxDateFilterPeriodType.SelectedIndex == (int)DateAndTime.PeriodTypes.Range);
            ToolStripLabelDateFilterAnd.Visible = (ToolStripComboBoxDateFilterPeriodType.SelectedIndex == (int)DateAndTime.PeriodTypes.Range && ToolStripComboBoxDateFilterPeriodValue.SelectedIndex == (int)DateAndTime.PeriodRangeValues.Between);
            HostDateTimePickerDateFilterTo.Visible = ToolStripLabelDateFilterAnd.Visible;
            ReadData();
        }

        private void DateTimePickerDateFilter_ValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void ToolStripComboBoxEventTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void DataGridViewMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Common.DataGridViews.ColumnHeaderMouseClick(DataGridViewMain, e, ref sortedColumn, ref sortOrder, [DataGridViewColumnEventoTipo, DataGridViewColumnFechaHora]))
            {
                OrderData();
            }
        }

        #endregion

        #region Main toolbar

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.AddVerify(this, DataGridViewMain, addPermission))
            {
                FormPointEvent formPointEvent = new(true, idPunto, 0);
                formPointEvent.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonView_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.ViewVerify(this, DataGridViewMain, entityNameSingle, entityIsFemale))
            {
                FormPointEvent formPointEvent = new(false, idPunto, ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEvento);
                formPointEvent.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (Common.DataGridViews.EditVerify(this, DataGridViewMain, editPermission, entityNameSingle, entityIsFemale))
            {
                FormPointEvent formPointEvent = new(true, idPunto, ((DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem).IdEvento);
                formPointEvent.ShowDialog(this);
                Common.DataGridViews.CommonActionFinalize(this, DataGridViewMain);
            }
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (!Common.DataGridViews.DeleteVerify(DataGridViewMain, deletePermission, entityNameSingle, entityIsFemale))
            {
                return;
            }

            DataGridViewRowData rowData = (DataGridViewRowData)DataGridViewMain.CurrentRow.DataBoundItem;
            string entidadDatos = $"Tipo: {rowData.EventoTipoNombre}\nFecha-hora: {rowData.FechaHora:g}";
            if (!Common.DataGridViews.DeleteConfirm(entityNameSingle, entityIsFemale, entidadDatos))
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            try
            {
                using Models.CSMapsContext context = new();
                Models.PuntoEvento puntoEvento = context.PuntoEventos.Find(idPunto, rowData.IdEvento);
                context.PuntoEventos.Attach(puntoEvento);
                context.PuntoEventos.Remove(puntoEvento);
                context.SaveChanges();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException dbUEx)
            {
                Common.DBErrors.DbUpdateException(dbUEx, entityNameSingle, entityIsFemale, Properties.Resources.StringActionDelete);
            }
            catch (Exception ex)
            {
                Common.DBErrors.OtherUpdateException(ex, entityNameSingle, entityIsFemale, Properties.Resources.StringActionDelete);
            }
            Common.RefreshLists.PointsEvents(idPunto);
            this.Cursor = Cursors.Default;
        }

        #endregion

    }
}
