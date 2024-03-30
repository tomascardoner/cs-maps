namespace CSMaps
{
    internal static class Program
    {
        internal const string ApplicationTitle = "CS-Maps";

#pragma warning disable S2223 // Non-constant static fields should not be visible
        internal static AppearanceConfig AppearanceConfig;
        internal static GeneralConfig GeneralConfig;
        internal static CardonerSistemas.Framework.Database.EFCore.ConnectionProperties DatabaseConfig;

        internal static Main.FormMdi formMdi;
#pragma warning restore S2223 // Non-constant static fields should not be visible

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Constants.SyncfusionLicenseKey);

            // Cargo los archivos de configuración de la aplicación
            if (!Configuration.LoadFiles())
            {
                return;
            }

            // Obtengo el connection string para la conexión a la base de datos
            CardonerSistemas.Framework.Database.EFCore.ConnectionStringBuilder connectionStringBuilder = new(DatabaseConfig);
            if (!connectionStringBuilder.PasswordUnencrypt(Constants.PublicEncryptionPassword, out string resultMessage))
            {
                MessageBox.Show(string.Format(Properties.Resources.StringDatabasePasswordUnencryptionError, resultMessage), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Models.CSMapsContext.ConnectionString = connectionStringBuilder.GetConnectionString();

            formMdi = new();
            Application.Run(formMdi);
        }

        static public void TerminateApplication()
        {
            if (formMdi != null)
            {
                CardonerSistemas.Framework.Base.Forms.MdiChildCloseAll(formMdi);
                CardonerSistemas.Framework.Base.Forms.CloseAll("FormMdi");
            }

            // Config
            AppearanceConfig = null;
            DatabaseConfig = null;
            GeneralConfig = null;
        }
    }
}