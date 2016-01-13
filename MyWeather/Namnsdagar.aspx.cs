using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeather.namnsdagarRef;

namespace MyWeather
{
    public partial class Namnsdagar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NamnsdagarSoapClient client = new NamnsdagarSoapClient();
            Label1.Text = client.NamnsdagarMetod(TextBox1.Text);
        }
    }
}