using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCSIentero
{
    public partial class _Default : System.Web.UI.Page
    {

        Entero objetoentero = new Entero();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TextBox1.Text);

            objetoentero.set(n);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (objetoentero.EsPar())
            {
                Label2.Text = "SI";
            }
        }


    }
}