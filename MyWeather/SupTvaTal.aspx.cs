using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeather.AdderarTreTalRef;
using MyWeather.SupTvaTalRef;

namespace MyWeather
{
    public partial class SupTvaTal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SupTvaTalSoapClient client = new SupTvaTalSoapClient();
            Label1.Text = client.SupTvatalMetod(TextBox1.Text, TextBox2.Text);
        }
    }
}