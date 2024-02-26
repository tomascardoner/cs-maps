using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Base.Configuration;

namespace CSMaps
{
    static class Configuration
    {
        private const string ConfigSubFolder = "Config";

        private const string DatabaseFileName = "Database.json";
        private const string GeneralFileName = "General.json";

        static internal bool LoadFiles()
        {
            string ConfigFolder;

            ConfigFolder = Path.Combine(Application.StartupPath, ConfigSubFolder);

            if (!Json.LoadFile(ConfigFolder, DatabaseFileName, ref Program.databaseConfig, true))
            {
                return false;
            }
            if (!Json.LoadFile(ConfigFolder, GeneralFileName, ref Program.generalConfig, true))
            {
                return false;
            }

            Program.generalConfig.ReportsPath = FileSystem.ProcessPath(Program.generalConfig.ReportsPath);

            return true;
        }
        static internal bool SaveFileDatabase()
        {
            string ConfigFolder;

            ConfigFolder = Path.Combine(Application.StartupPath, ConfigSubFolder);

            return Json.SaveFile(ConfigFolder, DatabaseFileName, ref Program.databaseConfig, true);
        }
    }
}