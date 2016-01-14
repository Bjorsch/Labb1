using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Labb1
{
    /// <summary>
    /// Summary description for MovieFromYear
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MovieFromYear : System.Web.Services.WebService
    {

        [WebMethod]
        public string MovieFromYearMothod2012()
        {
            var textFile = System.IO.File.ReadAllLines(@"C:\Skola\WCF\GitHub\Labb1\MyWeather\Movies.txt");
            var text = "";
            
            for (int i = 0; i < textFile.Length; i++)
            {
                var movie = textFile[i].Split(',');
                if (movie.Contains("2012"))
                {
                    text += movie[1] + "\r\n" ;
                }
            }
            return text;
        }
    }
}
