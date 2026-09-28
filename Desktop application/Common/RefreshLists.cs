namespace CSMaps.Common;

internal static class RefreshLists
{

    internal static void UsersGroups(byte idUserGroup = 0)
    {
        Forms.GetUsersGroups()?.ReadData(idUserGroup);
    }

    internal static void Users(short idUser = 0)
    {
        Forms.GetUsers()?.ReadData(idUser);
    }

    internal static void Entities(short idEntity = 0)
    {
        Forms.GetEntities()?.ReadData(idEntity);
    }

    internal static void Settlements(short idSettlement = 0)
    {
        Forms.GetSettlements()?.ReadData(idSettlement);
    }

    internal static async Task PointsAsync(int idPoint = 0)
    {
        Forms.GetPoints()?.ReadData(idPoint);
        await PointsEventsAsync(idPoint);
    }

    internal static async Task PointsDataAsync(int idPoint = 0)
    {
        var form = Forms.GetPointsDataAndEvents();
        if (form != null)
        {
            await form.ReadData(idPoint);
        }
    }

    internal static async Task PointsEventsAsync(int idPoint = 0, short idEvent = 0)
    {
        await PointsDataAsync(idPoint);
        Forms.GetPointEvents()?.ReadData(idEvent);
    }
}
