using CardonerSistemas.Framework.Database;
using CardonerSistemas.Framework.Base;

namespace CSMaps.Common
{
    internal static class DBErrors
    {
        internal static void DbUpdateException(Microsoft.EntityFrameworkCore.DbUpdateException ex, string entityNameSingle, bool entityIsFemale, string actionName)
        {
            string message;
            switch (EntityFramework.TryDecodeDbUpdateException(ex))
            {
                case EntityFramework.Errors.RelatedEntity:
                    message = string.Format(entityIsFemale ? Properties.Resources.StringEntityRelatedDataErrorFemale : Properties.Resources.StringEntityRelatedDataErrorMale, entityNameSingle, actionName);
                    break;
                case EntityFramework.Errors.DuplicatedEntity:
                    message = string.Format(entityIsFemale ? Properties.Resources.StringEntityDuplicatedUniqueKeyErrorFemale : Properties.Resources.StringEntityDuplicatedUniqueKeyErrorMale, entityNameSingle, actionName);
                    break;
                case EntityFramework.Errors.PrimaryKeyViolation:
                    message = string.Format(entityIsFemale ? Properties.Resources.StringEntityDuplicatedPrimaryKeyErrorFemale : Properties.Resources.StringEntityDuplicatedPrimaryKeyErrorMale, entityNameSingle, actionName);
                    break;
                default:
                    OtherUpdateException(ex, entityNameSingle, entityIsFemale, actionName);
                    return;
            }
            MessageBox.Show(message, Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void OtherUpdateException(Exception ex, string entityNameSingle, bool entityIsFemale, string actionName)
        {
            Error.ProcessException(ex, string.Format(entityIsFemale ? Properties.Resources.StringEntitySaveChangesErrorFemale : Properties.Resources.StringEntitySaveChangesErrorMale, entityNameSingle, actionName));
        }
    }
}
