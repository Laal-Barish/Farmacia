using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentación
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTecnico_Click(object sender, EventArgs e)
        {
            //Llamar al formulario técnico
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Llamar al formulario químico
            Response.Redirect("QF.aspx");
        }

        protected void btnAdministrador_Click(object sender, EventArgs e)
        {

        }
    }
}