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




        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Entero objetoenteroa = new Entero();

            int n = int.Parse(TextBox1.Text);

            objetoenteroa.set(n);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Entero objetoentero = new Entero();

            int n = int.Parse(TextBox1.Text);

            objetoentero.set(n);

            if (objetoentero.EsPar())
            {
                Label2.Text = "SI";
            }
            else {
                Label2.Text = "NO";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Entero objetoentero1 = new Entero();

            int n = int.Parse(TextBox1.Text);

            objetoentero1.set(n);

             int resultado=objetoentero1.Ordenado();
             Label3.Text = resultado.ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Entero objetoentero1 = new Entero();

            //int n = int.Parse(TextBox1.Text);

            //objetoentero1.set(n);

            int resultado = objetoentero1.EliminarMayor(917852);
            Label4.Text = resultado.ToString();
        }


    }
}