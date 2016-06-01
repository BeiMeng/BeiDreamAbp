using Abp.Application.Navigation;
using Abp.Localization;

namespace BeiDream.Mpa
{
    public class BeiDreamNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            SetMenuReplyMeun(context);
            SetMicroSiteMeun(context);
            SetSysManageMeun(context);
        }
        /// <summary>
        /// 设置(微信菜单回复)菜单导航栏(MenuReply)
        /// </summary>
        /// <param name="context"></param>
        private void SetMenuReplyMeun(INavigationProviderContext context)
        {
            context.Manager.Menus.Add("MenuReply", new MenuDefinition("MenuReply", L("菜单回复")));
            context.Manager.Menus["MenuReply"]
                .AddItem(new MenuItemDefinition(
                    "BusinessOne",
                    L("业务模块一"),
                    icon: "fa fa-music"
                    ).AddItem(new MenuItemDefinition(
                    "Users",
                    L("菜单设置"),
                    url: "/MenuReply/MenuSetting",
                    icon: "fa fa-music",
                    requiresAuthentication: true
                    )).AddItem(new MenuItemDefinition(
                        "Roles",
                        L("业务二"),
                        url: "/SystemManage/Roles",
                        icon: "fa fa-music",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "AuditLogs",
                        L("业务三"),
                        url: "/SystemManage/AuditLogs",
                        icon: "fa fa-music",
                        requiresAuthentication: true
                    ))
                ).AddItem(
                    new MenuItemDefinition(
                        "Business",
                        L("业务模块二"),
                        icon: "fa fa-info"
                        ).AddItem(new MenuItemDefinition(
                        "InsuranceTypes",
                        L("业务三"),
                        url: "/Business/InsuranceTypes",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "CooperationCompanys",
                        L("业务四"),
                        url: "/Business/CooperationCompanys",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "VirtualCustomers",
                        L("业务五"),
                        url: "/Business/VirtualCustomers",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        L("业务模块三"),
                        url: "/About",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                        )
                );
        }
        /// <summary>
        /// 设置微网站导航栏(MicroSite)
        /// </summary>
        /// <param name="context"></param>
        private void SetMicroSiteMeun(INavigationProviderContext context)
        {
            context.Manager.Menus.Add("MicroSite", new MenuDefinition("MicroSite", L("微网站")));
            context.Manager.Menus["MicroSite"]
                .AddItem(new MenuItemDefinition(
                    "BusinessOne",
                    L("系统设置一"),
                    icon: "fa fa-music"
                    ).AddItem(new MenuItemDefinition(
                    "Users",
                    L("文章管理"),
                    url: "/MicroSite/Article",
                    icon: "fa fa-music",
                    requiresAuthentication: true
                    )).AddItem(new MenuItemDefinition(
                        "Roles",
                        L("设置二"),
                        url: "/SystemManage/Roles",
                        icon: "fa fa-music",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "AuditLogs",
                        L("设置三"),
                        url: "/SystemManage/AuditLogs",
                        icon: "fa fa-music",
                        requiresAuthentication: true
                    ))
                ).AddItem(
                    new MenuItemDefinition(
                        "Business",
                        L("系统设置二"),
                        icon: "fa fa-info"
                        ).AddItem(new MenuItemDefinition(
                        "InsuranceTypes",
                        L("设置三"),
                        url: "/Business/InsuranceTypes",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "CooperationCompanys",
                        L("设置四"),
                        url: "/Business/CooperationCompanys",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "VirtualCustomers",
                        L("设置五"),
                        url: "/Business/VirtualCustomers",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        L("系统设置三"),
                        url: "/About",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                        )
                );
        }
        /// <summary>
        /// 设置系统管理导航栏(SysManage)
        /// </summary>
        /// <param name="context"></param>
        private void SetSysManageMeun(INavigationProviderContext context)
        {
            context.Manager.Menus.Add("SysManage", new MenuDefinition("SysManage", L("系统管理")));
            context.Manager.Menus["SysManage"]
                .AddItem(new MenuItemDefinition(
                    "BusinessOne",
                    L("系统管理一"),
                    icon: "fa fa-music"
                    ).AddItem(new MenuItemDefinition(
                    "Users",
                    L("用户管理"),
                    url: "/SysManage/User",
                    icon: "fa fa-music",
                    requiresAuthentication: true
                    )).AddItem(new MenuItemDefinition(
                        "Roles",
                        L("系统二"),
                        url: "/SystemManage/Roles",
                        icon: "fa fa-music",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "AuditLogs",
                        L("系统三"),
                        url: "/SystemManage/AuditLogs",
                        icon: "fa fa-music",
                        requiresAuthentication: true
                    ))
                ).AddItem(
                    new MenuItemDefinition(
                        "Business",
                        L("系统管理二"),
                        icon: "fa fa-info"
                        ).AddItem(new MenuItemDefinition(
                        "InsuranceTypes",
                        L("系统三"),
                        url: "/Business/InsuranceTypes",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "CooperationCompanys",
                        L("系统四"),
                        url: "/Business/CooperationCompanys",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "VirtualCustomers",
                        L("系统五"),
                        url: "/Business/VirtualCustomers",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        L("系统管理三"),
                        url: "/About",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new FixedLocalizableString(name);
        }
    }
}