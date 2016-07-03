using System.Reflection;
using Abp.Modules;
using BeiDream.Core;

namespace BeiDream.Application
{
     [DependsOn(typeof(CoreModule))]
    public class ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}