using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeather.AdderarTreTalRef;

namespace MyWeather
{
    public partial class TreTal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AdderaTreTalSoapClient client = new AdderaTreTalSoapClient();
            Label1.Text = client.AdderaTreTalMetod(TextBox1.Text, TextBox2.Text, TextBox3.Text);
        }
    }
}