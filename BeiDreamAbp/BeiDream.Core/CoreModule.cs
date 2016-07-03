using System.Reflection;
using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Modules;
using Abp.Net.Mail;
using Abp.Zero;
using Abp.Zero.Configuration;
using BeiDream.Core.Admin.SysManage.Authorization.Roles;
using BeiDream.Core.Admin.SysManage.Authorization.Users;
using BeiDream.Core.Admin.SysManage.MultiTenancy;

namespace BeiDream.Core
{
    /// <summary>
    /// Core (domain) module of the application.
    /// </summary>
    [DependsOn(typeof(AbpZeroCoreModule),typeof(AbpAutoMapperModule)                                  )]
    public class CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            //Add/remove localization sources
            //Configuration.Localization.Sources.Add(
            //    new DictionaryBasedLocalizationSource(
            //        "AbpZeroTemplate",
            //        new XmlEmbeddedFileLocalizationDictionaryProvider(
            //            Assembly.GetExecutingAssembly(),
            //            "MyCompanyName.AbpZeroTemplate.Localization.AbpZeroTemplate"
            //            )
            //        )
            //    );

            ////Adding feature providers
            //Configuration.Features.Providers.Add<AppFeatureProvider>();

            ////Adding setting providers
            //Configuration.Settings.Providers.Add<AppSettingProvider>();

            ////Adding notification providers
            //Configuration.Notifications.Providers.Add<AppNotificationProvider>();

            //Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = false;

            //Enable LDAP authentication (It can be enabled only if MultiTenancy is disabled!)
            //Configuration.Modules.ZeroLdap().Enable(typeof(AppLdapAuthenticationSource));

            //Configure roles
            //AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            //if (DebugHelper.IsDebug)
            //{
            //    //Disabling email sending in debug mode
            //    IocManager.Register<IEmailSender, NullEmailSender>(DependencyLifeStyle.Transient);
            //}
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}