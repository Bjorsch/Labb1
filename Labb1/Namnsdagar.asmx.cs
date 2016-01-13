using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Services;

namespace Labb1
{
    /// <summary>
    /// Summary description for Namnsdagar
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Namnsdagar : System.Web.Services.WebService
    {

        [WebMethod]
        public string NamnsdagarMetod(string input)
        {
            var textFile = System.IO.File.ReadAllLines(@"C:\Skola\WCF\GitHub\Labb1\MyWeather\Namnsdagar.txt");
            var text = "";

            for (int i = 0; i < textFile.Length; i++)
            {
                var kalle = textFile[i].Split(' ', ',');
                if (kalle.Contains(input))
                {
                    text = kalle[0] + "/" + kalle[1];
                }
            }        
            return text;
        }
    }
}
