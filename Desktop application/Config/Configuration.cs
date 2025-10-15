namespace CSMaps.config;

internal static class Configuration
{
    private const string ConfigSubFolder = "config";

    private const string AppearanceFileName = "Appearance.json";
    private const string DatabaseFileName = "Database.json";
    private const string GeneralFileName = "General.json";

    internal static bool LoadFiles()
    {
        var configFolder = Path.Combine(Application.StartupPath, ConfigSubFolder);

        if (!CardonerSistemas.Framework.Base.Configuration.Json.LoadFile(configFolder, AppearanceFileName, ref Program.AppearanceConfig, true))
        {
            return false;
        }

        if (!CardonerSistemas.Framework.Base.Configuration.Json.LoadFile(configFolder, DatabaseFileName, ref Program.DatabaseConfig, true))
        {
            return false;
        }

        if (!CardonerSistemas.Framework.Base.Configuration.Json.LoadFile(configFolder, GeneralFileName, ref Program.GeneralConfig, true))
        {
            return false;
        }

        Program.GeneralConfig.ReportsPath = CardonerSistemas.Framework.Base.FileSystem.ProcessPath(Program.GeneralConfig.ReportsPath);

        return true;
    }

    internal static bool SaveFileDatabase()
    {
        var configFolder = Path.Combine(Application.StartupPath, ConfigSubFolder);

        return CardonerSistemas.Framework.Base.Configuration.Json.SaveFile(configFolder, DatabaseFileName, ref Program.DatabaseConfig, true);
    }
}