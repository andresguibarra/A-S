using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPagina
{
    public class CustomViewEngine : RazorViewEngine
    {
        public CustomViewEngine()
        {
            var viewLocations = new[] {  
            //"~/Views/{1}/{0}.aspx",  
            "~/Views/{1}/{0}.cshtml",  
            //"~/Views/Shared/{0}.aspx",  
            "~/Views/Shared/{0}.cshtml",  
            "~/Views/Admin/{1}/{0}.cshtml"
            //"~/Views/Admin/Features/{0}.cshtml"
            // etc
        };

            this.PartialViewLocationFormats = viewLocations;
            this.ViewLocationFormats = viewLocations;
        }

    }
}