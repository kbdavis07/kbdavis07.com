using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KB.App_Start
{
    public class CustomViewLocation : RazorViewEngine
    {
        public CustomViewLocation()
        {
            ViewLocationFormats = new[]
            {
            "~/Themes/{1}/{0}.cshtml", "~/Themes/{1}/{0}.vbhtml",
            "~/Themes/Common/{0}.cshtml", "~/Themes/Common/{0}.vbhtml"
        };

            MasterLocationFormats = new[]
            {
            "~/Themes/{1}/{0}.cshtml", "~/Themes/{1}/{0}.vbhtml",
            "~/Themes/Common/{0}.cshtml", "~/Themes/Common/{0}.vbhtml"
        };

            PartialViewLocationFormats = new[]
            {
            "~/Themes/{1}/{0}.cshtml", "~/Themes/{1}/{0}.vbhtml",
            "~/Themes/Common/{0}.cshtml", "~/Themes/Common/{0}.vbhtml"
        };
        }

    }
}