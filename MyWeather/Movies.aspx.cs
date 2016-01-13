using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeather.MoviesRef;

namespace MyWeather
{
    public partial class Movies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MovieSoapClient client = new MovieSoapClient();
            Label1.Text = client.MoviesMethod(TextBox1.Text);
        }
    }
}