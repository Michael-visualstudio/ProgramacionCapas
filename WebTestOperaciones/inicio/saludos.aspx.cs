using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTestOperaciones.inicio
{
    public partial class saludos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            Funciones.Operaciones op = new Funciones.Operaciones();
            double [] x = new double[] { 10, 20, 20, 40, 55 };
            this.lblSaludos.Text = op.Saludo(this.txtNombre.Text);
            this.txtR.Text = op.Suma(x).ToString();
        }
    }
}