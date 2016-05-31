using System.Reflection;
using Abp.Modules;
using Abp.WebApi;

namespace BeiDream.WebApi
{
    [DependsOn(typeof(AbpWebApiModule))]
    public class WebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}