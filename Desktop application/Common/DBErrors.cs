using System.Globalization;
using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Database.EFCore;

namespace CSMaps.Common;

internal static class DBErrors
{
    internal static void DbUpdateException(Microsoft.EntityFrameworkCore.DbUpdateException ex, string entityNameSingle, bool entityIsFemale, string actionName)
    {
        var message = string.Empty;
        switch (Errors.TryDecodeDbUpdateException(ex))
        {
            case Errors.ErrorTypes.RelatedEntity:
                message = string.Format(CultureInfo.CurrentCulture, entityIsFemale ? Properties.Resources.StringEntityRelatedDataErrorFemale : Properties.Resources.StringEntityRelatedDataErrorMale, entityNameSingle, actionName);
                break;
            case Errors.ErrorTypes.DuplicatedEntity:
                message = string.Format(CultureInfo.CurrentCulture, entityIsFemale ? Properties.Resources.StringEntityDuplicatedUniqueKeyErrorFemale : Properties.Resources.StringEntityDuplicatedUniqueKeyErrorMale, entityNameSingle, actionName);
                break;
            case Errors.ErrorTypes.PrimaryKeyViolation:
                message = string.Format(CultureInfo.CurrentCulture, entityIsFemale ? Properties.Resources.StringEntityDuplicatedPrimaryKeyErrorFemale : Properties.Resources.StringEntityDuplicatedPrimaryKeyErrorMale, entityNameSingle, actionName);
                break;
            case Errors.ErrorTypes.NoDBError:
                break;
            case Errors.ErrorTypes.Unknown:
                break;
            case Errors.ErrorTypes.InvalidColumn:
                break;
            case Errors.ErrorTypes.UserDefinedError:
                break;
            default:
                OtherUpdateException(ex, entityNameSingle, entityIsFemale, actionName);
                return;
        }

        MessageBox.Show(message, Program.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    internal static void OtherUpdateException(Exception ex, string entityNameSingle, bool entityIsFemale, string actionName)
    {
        Error.ProcessException(ex, string.Format(CultureInfo.CurrentCulture, entityIsFemale ? Properties.Resources.StringEntitySaveChangesErrorFemale : Properties.Resources.StringEntitySaveChangesErrorMale, entityNameSingle, actionName));
    }
}