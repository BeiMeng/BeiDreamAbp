using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
// Microsoft.Owin.Host.SystemWeb,OWIN服务器实现,它允许基于OWIN的应用程序运行在IIS中
//，并能够使用ASP.NET的请求管道(引用此dll,才能程序启动时执行下面的代码)
[assembly: OwinStartup(typeof(BeiDream.MetronicMpa.Startup))]

namespace BeiDream.MetronicMpa
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Admin/Account/Login")
            });
        }
    }
}
