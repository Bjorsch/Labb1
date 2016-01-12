using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeather.WeatherRef;

namespace MyWeather
{
    public partial class Weather_webform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WeatherRef.HalloSoapClient client = new HalloSoapClient();
            Label1.Text = client.Weather();
        }
    }
}