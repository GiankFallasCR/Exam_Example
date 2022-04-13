using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos.Clases;
using CapaLogica;


namespace PrimerParcial
{
    public partial class DatosEmpleado : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        MetodosEmpleado emp = new MetodosEmpleado();

        protected void btn_Incluir_Click(object sender, EventArgs e)
        {
            txtSalarioBruto.Text = Convert.ToString(Convert.ToUInt32(txtHoras.Text)
* Convert.ToUInt32(txtHoras.Text));
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = txtNombre.Text;
            decimal horasL = Convert.ToInt32(txtHoras.Text);
            decimal salarioH = Convert.ToInt32(txtHoras.Text);
            decimal salarioB = Convert.ToInt32(txtSalarioBruto.Text);
            emp.Guardar(codigo, nombre, horasL, salarioH, salarioB);
        }
    }
}