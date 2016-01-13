using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Labb1
{
    /// <summary>
    /// Summary description for SupTvaTal
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SupTvaTal : System.Web.Services.WebService
    {

        [WebMethod]
        public string SupTvatalMetod(string tal1, string tal2)
        {
            var calc = (int.Parse(tal1) - int.Parse(tal2)).ToString();
            return calc;
        }
    }
}
