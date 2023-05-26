using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace WcfUsuarios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioUsuario.svc o ServicioUsuario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioUsuario : IServicioUsuario
    {
        public string Acceder(Usuario user)
        {
            string mensaje = null;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-87IQ4MT\\SQLEXPRESS;Initial Catalog=Prueba_Registro;User ID=sa;Password=goter121");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE Username='" + user.Username + "' AND PasswordUser='" + user.Password + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    mensaje = user.Username + " Te Logeaste Exitosamente.";
                }
                else
                {
                    mensaje = "El Usuario " + user.Username + " No existe o la contraseña es Erronea.";
                }
            }
            catch (Exception ex) 
            {
                return ex.ToString();
            }
            return mensaje;
        }
    }
}
