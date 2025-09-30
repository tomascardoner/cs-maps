using CSMaps.Main;
using System.Diagnostics;
using System.Reflection;

namespace CSMaps
{
    internal static class Program
    {
#pragma warning disable S2223 // Non-constant static fields should not be visible
        // Application info
        internal static CardonerSistemas.Framework.Base.Application.Info Info = new(Assembly.GetExecutingAssembly());
        internal static string LicensedCompany;

        // Config files
        internal static AppearanceConfig AppearanceConfig;
        internal static GeneralConfig GeneralConfig;
        internal static CardonerSistemas.Framework.Database.EFCore.ConnectionProperties DatabaseConfig;

        // Parameters
        internal static List<Models.Parametro> Parametros;
        internal static List<Models.UsuarioParametro> ParametrosUsuario;

        // Usuarios
        internal static List<Models.UsuarioGrupoPermiso> Permisos;
        internal static Models.Usuario Usuario;

        // Instancias
        internal static Main.FormMdi FormMdi;
#pragma warning restore S2223 // Non-constant static fields should not be visible

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cursor.Current = Cursors.AppStarting;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            ApplicationConfiguration.Initialize();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Constants.SyncfusionLicenseKey);

            // Cargo los archivos de configuración de la aplicación
            if (!Configuration.LoadFiles())
            {
                TerminateApplication();
                return;
            }

            // Muestro el SplashScreen y cambio el puntero del mouse para indicar que la aplicación está iniciando.
            using FormSplash formSplash = new();
            formSplash.Show();
            formSplash.Cursor = Cursors.AppStarting;
            formSplash.labelStatus.Text = "Estableciendo conexión a la base de datos...";
            Application.DoEvents();

            // Obtengo el connection string para la conexión a la base de datos
            CardonerSistemas.Framework.Database.EFCore.ConnectionStringBuilder connectionStringBuilder = new(DatabaseConfig);
            if (!connectionStringBuilder.DatasourceSelected)
            {
                formSplash.Close();
                TerminateApplication();
                return;
            }
            if (!connectionStringBuilder.PasswordUnencrypt(Constants.PublicEncryptionPassword, out string resultMessage))
            {
                MessageBox.Show(string.Format(Properties.Resources.StringDatabasePasswordUnencryptionError, Environment.NewLine, resultMessage), Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                formSplash.Close();
                TerminateApplication();
                return;
            }
            Models.CSMapsContext.ConnectionString = connectionStringBuilder.GetConnectionString();

            // Load parameters
            if (!Parameters.LoadFromDatabase())
            {
                formSplash.Close();
                TerminateApplication();
                return;
            }

            formSplash.labelStatus.Text = "Estableciendo conexión a la base de datos...OK";
            Application.DoEvents();

            // Verifico que la Base de Datos corresponda a esta Aplicación a través del GUID guardado en los Parámetros
            if (Parameters.GetText(Parameters.ParametersId.ApplicationDatabaseGuid) != Constants.ApplicationDatabaseGuid)
            {
                MessageBox.Show("La base de datos especificada en la configuración del sistema no pertenece a esta aplicación.", Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                formSplash.Close();
                TerminateApplication();
                return;
            }

            // Obtengo el nombre de la compañía licenciada y lo muestro
            if (!CardonerSistemas.Framework.Cryptography.StringCipher.Decrypt(Parameters.GetText(Parameters.ParametersId.LicensedCompany), Constants.ApplicationLicensePassword, out LicensedCompany))
            {
                MessageBox.Show("La información de la licencia es incorrecta.", Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                formSplash.Close();
                TerminateApplication();
                return;
            }
            formSplash.labelLicensedTo.Text = LicensedCompany.ToUpper();
            formSplash.labelLicensedTo.Visible = true;
            Application.DoEvents();

            // Tomo el tiempo de inicio para controlar los segundos mínimos que se debe mostrar el Splash Screen
            Stopwatch stopwatch = Stopwatch.StartNew();

            FormMdi = new() { Enabled = false };
            FormMdi.Show();

            formSplash.labelStatus.Text = "Todo listo.";
            formSplash.Focus();
            Application.DoEvents();

            // Espero el tiempo mínimo para mostrar el Splash Screen y después lo cierro
            if (!CardonerSistemas.Framework.Base.Instance.IsRunningUnderIde())
            {
                while (stopwatch.Elapsed.TotalSeconds < AppearanceConfig.MinimumSplashScreenDisplaySeconds)
                {
                    Application.DoEvents();
                }
            }
            formSplash.Close();

            if (CardonerSistemas.Framework.Base.Instance.IsRunningUnderIde())
            {
                // Como se está ejecutando dentro del IDE de Visual Studio, en lugar de pedir Usuario y contraseña, asumo que es el Administrador
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
                using Users.FormUserLogin formUserLogin = new();
                if (formUserLogin.ShowDialog(FormMdi) == DialogResult.Cancel)
                {
                    Application.Exit();
                    return;
                }
                formUserLogin.Close();
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