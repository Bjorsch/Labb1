﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Labb1
{
    /// <summary>
    /// Summary description for Hallo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Hallo : System.Web.Services.WebService
    {

        [WebMethod]
        public string Weather()
        {
            var value = "Imorgon blir det sol";
            return value;
        }
    }
}
