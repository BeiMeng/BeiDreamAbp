using System;
using System.Linq;
using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;
using BeiDream.Application;
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
            //应用服务层动态webapi方法的创建(app为生成的动态webapi的前缀名)
            DynamicApiControllerBuilder.ForAll<IApplicationService>(typeof(ApplicationModule).Assembly, "app").Build();
            ConfigureSwaggerUi();
        }
        private void ConfigureSwaggerUi()
        {
            var webApiAssembly = typeof(WebApiModule).Assembly;
            var applicationAssembly = typeof(ApplicationModule).Assembly;
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "BeiDream.WebApi");
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                    //显示手动添加的webapi注释文档配置
                    c.IncludeXmlComments(GetXmlCommentsPath(webApiAssembly.GetName().Name));
                    //动态生成的webapi的注释必须写着接口上,才能在SwaggerUi界面上显示出来
                    c.IncludeXmlComments(GetXmlCommentsPath(applicationAssembly.GetName().Name));
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