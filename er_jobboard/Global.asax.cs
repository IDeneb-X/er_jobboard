using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace er_jobboard
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
///////////////////Developer purpose only//////////////////////////////////////////////////
            //Enable Automatic migracion at statar
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<JobboardDBContext,
                Migrations.Configuration>());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
