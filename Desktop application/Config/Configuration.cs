namespace CSMaps
{
    static class Configuration
    {
        private const string ConfigSubFolder = "Config";

        private const string AppearanceFileName = "Appearance.json";
        private const string DatabaseFileName = "Database.json";
        private const string GeneralFileName = "General.json";

        static internal bool LoadFiles()
        {
            string ConfigFolder;

            ConfigFolder = Path.Combine(Application.StartupPath, ConfigSubFolder);

            if (!CardonerSistemas.Framework.Base.Configuration.Json.LoadFile(ConfigFolder, AppearanceFileName, ref Program.AppearanceConfig, true))
            {
                return false;
            }
            if (!CardonerSistemas.Framework.Base.Configuration.Json.LoadFile(ConfigFolder, DatabaseFileName, ref Program.DatabaseConfig, true))
            {
                return false;
            }
            if (!CardonerSistemas.Framework.Base.Configuration.Json.LoadFile(ConfigFolder, GeneralFileName, ref Program.GeneralConfig, true))
            {
                return false;
            }

            Program.GeneralConfig.ReportsPath = CardonerSistemas.Framework.Base.FileSystem.ProcessPath(Program.GeneralConfig.ReportsPath);

            return true;
        }
        static internal bool SaveFileDatabase()
        {
            string ConfigFolder;

            ConfigFolder = Path.Combine(Application.StartupPath, ConfigSubFolder);

            return CardonerSistemas.Framework.Base.Configuration.Json.SaveFile(ConfigFolder, DatabaseFileName, ref Program.DatabaseConfig, true);
        }
    }
}