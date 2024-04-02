using CardonerSistemas.Framework.Base;

namespace CSMaps.Users
{
    static class Users
    {
        static internal string GetDescription(Models.CSMapsContext context, short idUsuario)
        {
            if (idUsuario == 0)
            {
                return string.Empty;
            }
            else
            {
                return context.Usuarios.Find(idUsuario).Nombre;
            }
        }

        static internal void LogIn()
        {
            Permissions.Load();

            // Leo los parámetros del usuario desde la base de datos
            UsersParameters.LoadFromDatabase();

            Program.FormMdi.ToolStripLabelUser.Image = Program.Usuario.Genero switch
            {
                Constants.GenderFemale => Properties.Resources.ImageMujer16,
                Constants.GenderMale => Properties.Resources.ImageHombre16,
                _ => null,
            };
            Program.FormMdi.ToolStripLabelUser.Text = Program.Usuario.Descripcion;
        }

        static internal void LogOut()
        {
            if (MessageBox.Show("¿Desea cerrar la sesión del usuario actual?", Program.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
}
