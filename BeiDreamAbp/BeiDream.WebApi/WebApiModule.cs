using System;
using System.Linq;
using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Swashbuckle.Application;

namespace BeiDream.WebApi
{
    /// <summary>
    /// WebApi启动模块
    /// </summary>
    [DependsOn(typeof(AbpWebApiModule))]
    public class WebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            ConfigureSwaggerUi();
        }
        private void ConfigureSwaggerUi()
        {
            var thisAssembly = typeof(WebApiModule).Assembly;
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "BeiDream.WebApi");
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                    //显示注释文档配置
                    c.IncludeXmlComments(GetXmlCommentsPath(thisAssembly.GetName().Name));
                })
                .EnableSwaggerUi();
        }
        /// <summary>
        /// 返回注释文档地址
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string GetXmlCommentsPath(string name)
        {
            return string.Format(@"{0}\bin\{1}.XML", AppDomain.CurrentDomain.BaseDirectory, name);
        }
    }
}