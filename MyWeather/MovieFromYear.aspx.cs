using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeather.MovieFromYearRef;

namespace MyWeather
{
    public partial class MovieFromYear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MovieFromYearSoapClient client = new MovieFromYearSoapClient();
            TextBox1.Text = client.MovieFromYearMothod2012();
        }
    }
}