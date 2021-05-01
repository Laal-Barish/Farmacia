using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentación
{
    public partial class QF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Declarar un objeto instanciando la clase
        static CapaNegocio.QF quimico1 = new CapaNegocio.QF();

        protected void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string dni = txtDni.Text;
            string domicilio = txtDomicilio.Text;
            string experienciaLaboral = txtExperienciaLaboral.Text;


            {

                quimico1.Apellidos = apellidos;
                quimico1.Nombres = nombres;
                quimico1.Dni = dni;
                quimico1.Domicilio = domicilio;
                quimico1.ExperienciaLaboral= experienciaLaboral;
                
                
                //Enviar un mensaje de conformidad
                Response.Write("Se ha agregado los atributos al objeto");

            }
        }

        protected void btnEscribir_Click1(object sender, EventArgs e)
        {
            //escribir los atributos del objeto
            Response.Write("Apellidos: " + quimico1.Apellidos +
                "   Nombres: " + quimico1.Nombres + "  Número de DNI: " + quimico1.Dni +
                 "   Domicilio: " + quimico1.Domicilio + "   Experiencia laboral: " + quimico1.ExperienciaLaboral);
        }



        protected void btnSupervisar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + quimico1.Supervisar() + "')</script>"); Response.Write(quimico1.Supervisar());
        }
                    
       
        protected void btnVerificar_Click1(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + quimico1.Verificar() + "')</script>");
                    }

        protected void btnDirigir_Click1(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + quimico1.Dirigir() + "')</script>");
        }

        protected void btnEvaluar_Click1(object sender, EventArgs e)
        {
            Response.Write("<script>alert('" + quimico1.Evaluar() + "')</script>");
        }
    }
}