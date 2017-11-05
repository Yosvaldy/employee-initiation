using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
//using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Appplication.Api.Infrastructure.Autofac
{
    public class AutofacConfig
    {
        public static void AutofacStartUp()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(WebApiApplication).Assembly);


            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacModule>();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver =
                 new AutofacWebApiDependencyResolver(container);

            //DependencyResolver.SetResolver(new AutofacWebApiDependencyResolver(container));
        }
    }
}