using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Conventions;
using Nancy.Diagnostics;
using Nancy.ViewEngines;
using System.Reflection;

namespace NancyAreasDemo
{
    public class NancyDemoBootstrapper : DefaultNancyBootstrapper
    {
        protected override DiagnosticsConfiguration DiagnosticsConfiguration
        {
            get { return new DiagnosticsConfiguration { Password = @"test" }; }
        }

        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            nancyConventions.ViewLocationConventions.Insert(0, (viewName, model, context) =>
            {
                if (string.IsNullOrWhiteSpace(context.ModulePath))
                    return null;

                return string.Concat("views/", context.ModulePath, "/", context.ModuleName, "/", viewName);
            });

            base.ConfigureConventions(nancyConventions);
        }
    }
}