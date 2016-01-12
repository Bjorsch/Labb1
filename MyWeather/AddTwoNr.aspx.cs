using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeather.add2numbers;

namespace MyWeather
{
    public partial class AddTwoNr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Adderar2TalSoapClient client = new Adderar2TalSoapClient();
            Label1.Text = client.PlusaIhop(TextBox1.Text, TextBox2.Text);
        }
    }
}