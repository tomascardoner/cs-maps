namespace CSMaps.Common
{
    internal static class DataGridViews
    {

        #region Items count text

        internal static string GetItemsCountText(string entityName, string entitiesName, int itemsCount)
        {
            return itemsCount switch
            {
                0 => string.Format(Properties.Resources.StringDatabaseItemsCountNone, entityName),
                1 => string.Format(Properties.Resources.StringDatabaseItemsCountOne, entityName),
                _ => string.Format(Properties.Resources.StringDatabaseItemsCountMany, entitiesName, itemsCount.ToString("N0")),
            };
        }

        #endregion

    }
}
