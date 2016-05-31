using System.Reflection;
using Abp.Modules;

namespace BeiDream.Application
{
    public class ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}