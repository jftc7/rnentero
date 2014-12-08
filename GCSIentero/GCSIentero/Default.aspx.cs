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

        public Entero objetoentero = new Entero();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (! IsPostBack) { 
                 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Entero objetoenteroa = new Entero();

            int n = int.Parse(TextBox1.Text);

            objetoentero.set(n);
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

            Entero objetoentero = new Entero();

            int n = int.Parse(TextBox1.Text);

            objetoentero.set(n);

             int resultado=objetoentero.DigitoMasRepetido();
             Label3.Text = resultado.ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {


            Entero objEntero = new Entero();

            
            int n = int.Parse(TextBox1.Text);

            objetoentero.set(n);

            Label4.Text = objetoentero.EliminarMayor().ToString();


        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Entero objEntero = new Entero();

            int n = int.Parse(TextBox1.Text);

            objetoentero.set(n);

            Label5.Text = objetoentero.Mayor().ToString();

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Entero objEntero = new Entero();

            int n = int.Parse(TextBox1.Text);

            objetoentero.set(n);

            Label6.Text = objetoentero.Ordenado().ToString();
        }

    }
}