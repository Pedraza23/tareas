using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tareas.entidades;
using Tareas.logica;

namespace Tareas
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            clUsuario oData = new clUsuario();
            oData.email = email.Text;
            oData.contraseña = contraseña.Text;

            clIngresarL oIngreso = new clIngresarL();
            clUsuario ingreso = oIngreso.mtdIngreso(oData);

            if (ingreso != null)
            {
                Response.Redirect("vista/inicio.aspx");
            }
        }
    }
}