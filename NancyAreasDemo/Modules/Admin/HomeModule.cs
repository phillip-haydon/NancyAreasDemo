using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyAreasDemo.Modules.Admin
{
    public class HomeModule : NancyModule  
    {
        public HomeModule() : base("admin")
        {
            Get["/"] = _ =>
            {
                return View["index"];
            };
        }
    }
}