namespace CSMaps.Common
{
    internal class RefreshLists
    {

        #region Declarations

        private const string ForNamemUsersGroups = "FormUsersGroups";
        private const string FormNamePointsDataAndEvents = "FormPointsDataAndEvents";
        private const string FormNamePointEvents = "FormPointEvents";

        #endregion

        internal static void UsersGroups(byte idUserGroup)
        {
            Form form;

            form = CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, ForNamemUsersGroups);
            if (form != null)
            {
                ((Users.FormUsersGroups)form).RefreshData(idUserGroup);
            }
        }

        internal static void PointsData(int idPunto)
        {
            Form form;

            form = CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNamePointsDataAndEvents);
            if (form != null)
            {
                _ = ((General.FormPointsDataAndEvents)form).ReadData(idPunto);
            }
        }

        internal static void PointsEvents(int idPunto, short idEvento)
        {
            Form form;

            form = CardonerSistemas.Framework.Base.Forms.GetInstance(Program.FormMdi.MdiChildren, FormNamePointsDataAndEvents);
            if (form != null)
            {
                _ = ((General.FormPointsDataAndEvents)form).ReadData(idPunto);
            }

            form = CardonerSistemas.Framework.Base.Forms.GetInstance(Application.OpenForms.Cast<Form>().ToArray(), FormNamePointEvents);
            if (form != null)
            {
                ((General.FormPointEvents)form).ReadData(idEvento);
            }
        }
    }
}
