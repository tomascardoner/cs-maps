using CardonerSistemas.Framework.Base;
using CSMaps.Main;

namespace CSMaps.Users;

internal static class Users
{
    internal static string GetDescription(Models.CSMapsContext context, short idUsuario)
    {
        return idUsuario == 0 ? string.Empty : context.Usuarios.Find(idUsuario).Nombre;
    }

    internal static void LogIn()
    {
        Permissions.Load();

        // Leo los parámetros del usuario desde la base de datos
        UsersParameters.LoadFromDatabase();

        Program.FormMdi.ToolStripLabelUser.Image = Program.Usuario.Genero switch
        {
            Main.Constants.GenderFemale => Properties.Resources.ImageMujer16,
            Main.Constants.GenderMale => Properties.Resources.ImageHombre16,
            _ => null,
        };
        Program.FormMdi.ToolStripLabelUser.Text = Program.Usuario.Descripcion;
    }

    internal static void LogOut()
    {
        if (MessageBox.Show("¿Desea cerrar la sesión del usuario actual?", Program.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Forms.CloseAll(Program.FormMdi.Name);
            Program.FormMdi.ToolStripLabelUser.Image = null;
            Program.FormMdi.ToolStripLabelUser.Text = string.Empty;
            Program.Usuario = null;

            using FormUserLogin formLogin = new();
            if (formLogin.ShowDialog(Program.FormMdi) == DialogResult.Cancel)
            {
                Application.Exit();
                return;
            }

            formLogin.Close();
        }
    }
}
