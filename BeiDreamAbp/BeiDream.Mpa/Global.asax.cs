using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Dependency;
using Abp.Reflection;
using Abp.Web;
using Castle.Facilities.Logging;

namespace BeiDream.Mpa
{
    public class MvcApplication : AbpWebApplication
    {
        /// <summary>
        /// web应用程序入口，最先启动位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Application_Start(object sender, EventArgs e)
        {
            /* This line provides better startup performance for the application by disabling detailed assembly investigation.
            * If you need deeper assembly investigation, remove it. */
            //AbpBootstrapper.IocManager.RegisterIfNot<IAssemblyFinder, CurrentDomainAssemblyFinder>();

            //以下方法的启动位置移到MpaWebModule的Initialize方法里
            //AreaRegistration.RegisterAllAreas();
            //RouteConfig.RegisterRoutes(RouteTable.Routes);

            IocManager.Instance.IocContainer.AddFacility<LoggingFacility>(f => f.UseLog4Net().WithConfig("log4net.config"));
            base.Application_Start(sender, e);
        }
    }
}
