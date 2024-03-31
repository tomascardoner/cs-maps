using System.Diagnostics;

namespace CSMaps
{
    internal static class Program
    {
        internal const string ApplicationTitle = "CS-Maps";

#pragma warning disable S2223 // Non-constant static fields should not be visible
        internal static AppearanceConfig AppearanceConfig;
        internal static GeneralConfig GeneralConfig;
        internal static CardonerSistemas.Framework.Database.EFCore.ConnectionProperties DatabaseConfig;

        internal static List<Models.Parametro> Parametros;
        internal static List<Models.UsuarioParametro> ParametrosUsuario;

        internal static string LicensedCompany;

        // Usuarios
        internal static List<Models.UsuarioGrupoPermiso> Permisos;
        internal static Models.Usuario Usuario;

        internal static Main.FormMdi FormMdi;
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

            // Cargo los archivos de configuraci�n de la aplicaci�n
            if (!Configuration.LoadFiles())
            {
                return;
            }

            // Obtengo el connection string para la conexi�n a la base de datos
            CardonerSistemas.Framework.Database.EFCore.ConnectionStringBuilder connectionStringBuilder = new(DatabaseConfig);
            if (!connectionStringBuilder.PasswordUnencrypt(Constants.PublicEncryptionPassword, out string resultMessage))
            {
                MessageBox.Show(string.Format(Properties.Resources.StringDatabasePasswordUnencryptionError, resultMessage), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Models.CSMapsContext.ConnectionString = connectionStringBuilder.GetConnectionString();

            // Load parameters
            if (!Parameters.LoadFromDatabase())
            {
                //formSplash.Close();
                TerminateApplication();
                return;
            }

            // Verifico que la Base de Datos corresponda a esta Aplicaci�n a trav�s del GUID guardado en los Par�metros
            if (Parameters.GetText(Parameters.ParametersId.ApplicationDatabaseGuid) != Constants.ApplicationDatabaseGuid)
            {
                MessageBox.Show("La base de datos especificada en la configuraci�n del sistema no pertenece a esta aplicaci�n.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //formSplash.Close();
                TerminateApplication();
                return;
            }

            // Obtengo el nombre de la compa��a licenciada y lo muestro
            if (!CardonerSistemas.Framework.Cryptography.StringCipher.Decrypt(Parameters.GetText(Parameters.ParametersId.LicensedCompany), Constants.ApplicationLicensePassword, out LicensedCompany))
            {
                MessageBox.Show("La informaci�n de la licencia es incorrecta.", Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //formSplash.Close();
                TerminateApplication();
                return;
            }
            //formSplash.labelLicensedTo.Text = licensedCompany;

            // Tomo el tiempo de inicio para controlar los segundos m�nimos que se debe mostrar el Splash Screen
            Stopwatch stopwatch = Stopwatch.StartNew();

            FormMdi = new() { Enabled = false };
            FormMdi.Show();

            //formSplash.labelStatus.Text = Properties.Resources.StringSplashStatusAllDone;
            //formSplash.Focus();
            Application.DoEvents();

            // Espero el tiempo m�nimo para mostrar el Splash Screen y despu�s lo cierro
            if (!CardonerSistemas.Framework.Base.Instance.IsRunningUnderIde())
            {
                while (stopwatch.Elapsed.TotalSeconds < AppearanceConfig.MinimumSplashScreenDisplaySeconds)
                {
                    Application.DoEvents();
                }
            }
            //formSplash.Close();

            if (CardonerSistemas.Framework.Base.Instance.IsRunningUnderIde())
            {
                // Como se est� ejecutando dentro del IDE de Visual Studio, en lugar de pedir Usuario y contrase�a, asumo que es el Administrador
                using Models.CSMapsContext context = new();
                try
                {
                    Usuario = context.Usuarios.Find(Constants.UserAdministratorId);
                    Users.Users.LogIn();
                }
                catch (Exception ex)
                {
                    CardonerSistemas.Framework.Base.Error.ProcessException(ex, "Error al obtener el usuario (administrador) desde la base datos.");
                    TerminateApplication();
                    return;
                }
            }
            else
            {
                using Users.FormUserLogin formLogin = new();
                if (formLogin.ShowDialog(FormMdi) == DialogResult.Cancel)
                {
                    Application.Exit();
                    return;
                }
                formLogin.Close();
            }

            // Cambio el puntero del mouse a modo normal
            FormMdi.Enabled = true;
            FormMdi.Cursor = Cursors.Default;
            Cursor.Current = Cursors.Default;

            // Inicio el loop sobre el form MDI principal
            Application.Run(FormMdi);
        }

        static public void TerminateApplication()
        {
            if (FormMdi != null)
            {
                CardonerSistemas.Framework.Base.Forms.MdiChildCloseAll(FormMdi);
                CardonerSistemas.Framework.Base.Forms.CloseAll("FormMdi");
            }

            // Config
            AppearanceConfig = null;
            DatabaseConfig = null;
            GeneralConfig = null;

            Parametros = null;
            ParametrosUsuario = null;

            Permisos = null;
            Usuario = null;
        }
    }
}