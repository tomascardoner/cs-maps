namespace CSMaps
{
    internal static class Program
    {
        internal const string ApplicationTitle = "CS-Maps";

        internal static AppearanceConfig AppearanceConfig;
        internal static GeneralConfig GeneralConfig;
        internal static CardonerSistemas.Framework.Database.Ado.SqlServer.DatabaseConfig DatabaseConfig;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cargo los archivos de configuración de la aplicación
            if (!Configuration.LoadFiles())
            {
                return;
            }

            // Obtengo el connection string para las conexiones de ADO .NET
            CardonerSistemas.Framework.Database.Ado.SqlServer database = new();
            if (!database.SetProperties(DatabaseConfig.Datasource, DatabaseConfig.Database, DatabaseConfig.UserId, DatabaseConfig.Password, DatabaseConfig.ConnectTimeout, DatabaseConfig.ConnectRetryCount, DatabaseConfig.ConnectRetryInterval))
            {
                return;
            }
            if (!database.PasswordUnencrypt(Constants.PublicEncryptionPassword, out string resultMessage))
            {
                MessageBox.Show(string.Format(Properties.Resources.StringDatabasePasswordUnencryptionError, resultMessage), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            database.CreateConnectionString();
            Models.CSMapsContext.ConnectionString = database.ConnectionString;

            Application.Run(new Main.FormMdi());
        }
    }
}