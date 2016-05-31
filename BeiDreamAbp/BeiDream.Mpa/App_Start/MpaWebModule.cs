using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Modules;
using Abp.Web.Mvc;

namespace BeiDream.Mpa
{
    [DependsOn(   //依赖模块,这样可以显示指定模块的加载顺序,被依赖的模块先加载(也可以直接把dll文件扔进项目的bin文件下,也会自动加载,但是执行顺序不能保证)
    typeof(AbpWebMvcModule))]
    public class MpaWebModule : AbpModule
    {
        public override void PreInitialize()
        {

        }

        public override void Initialize()
        {
            //注入当前程序集到DI容器
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            //注册区域
            AreaRegistration.RegisterAllAreas();
            //注册MVC路由
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        public override void PostInitialize()
        {
        }
    }
}