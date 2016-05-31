using BeiDream.Mpa;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
//依赖Owin.dll,Microsoft.Owin.dll
namespace BeiDream.Mpa
{
    /// <summary>
    /// 添加Owin的入口启动文件
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
