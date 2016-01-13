using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Labb1
{
    /// <summary>
    /// Summary description for Movie
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Movie : System.Web.Services.WebService
    {

        [WebMethod]
        public string MoviesMethod(string textbox)
        {
            var textFile = System.IO.File.ReadAllLines(@"C:\Skola\WCF\GitHub\Labb1\MyWeather\Movies.txt");
            var text = "";
            var theTrim = textbox.Replace(" ", "");
            for (int i = 0; i < textFile.Length; i++)
            {
                var movie = textFile[i].Replace(" ","").Split(',');
                if (movie.Contains(theTrim))
                {
                    text = "År: " + movie[0];
                }
            }
            return text;
        }
    }
}
