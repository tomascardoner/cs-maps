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

    internal static void Points(int idPoint = 0)
    {
        Forms.GetPoints()?.ReadData(idPoint);
        PointsEvents(idPoint);
    }

    internal static void PointsData(int idPoint = 0)
    {
        Forms.GetPointsDataAndEvents()?.ReadData(idPoint);
    }

    internal static void PointsEvents(int idPoint = 0, short idEvent = 0)
    {
        PointsData(idPoint);
        Forms.GetPointEvents()?.ReadData(idEvent);
    }
}
