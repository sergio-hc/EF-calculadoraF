using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(TextBox1.Text);
        int b = Convert.ToInt32(TextBox2.Text);
        int r = PortableLibrary3.MiModulo.suma(a, b);
        TextBox3.Text = r.ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(TextBox1.Text);
        int b = Convert.ToInt32(TextBox2.Text);
        int r = PortableLibrary3.MiModulo.resta(a, b);
        TextBox3.Text = r.ToString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(TextBox1.Text);
        int b = Convert.ToInt32(TextBox2.Text);
        int r = PortableLibrary3.MiModulo.multi(a, b);
        TextBox3.Text = r.ToString();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(TextBox1.Text);
        int b = Convert.ToInt32(TextBox2.Text);
        int r = PortableLibrary3.MiModulo.divi(a, b);
        TextBox3.Text = r.ToString();
    }
}