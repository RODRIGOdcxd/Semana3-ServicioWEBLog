using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClienteUsuario.ServiceReference1;
namespace ClienteUsuario
{
    public partial class FrmUsuario : System.Web.UI.Page
    {
        ServicioUsuarioClient ServicioCliene = new ServicioUsuarioClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Username = txtUsuario.Text;
            usuario.Password = txtPassword.Text;
            labelMensaje.Text = ServicioCliene.Acceder(usuario);
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }
    }
}