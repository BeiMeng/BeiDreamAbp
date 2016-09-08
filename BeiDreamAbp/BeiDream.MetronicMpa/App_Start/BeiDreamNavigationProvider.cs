using Abp.Application.Navigation;
using Abp.Localization;

namespace BeiDream.MetronicMpa
{
    /// <summary>
    /// UserMenu扩展数据
    /// </summary>
    public class UserMenuExtendData
    {
        public string Icon { get; set; }
    }

    public class BeiDreamNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            SetStudentsManageMeun(context);
            SetTeachingManageMeun(context);
            SetWorkingManageMeun(context);
            SetSysManageMeun(context);
        }
        /// <summary>
        /// 设置(学生管理)菜单导航栏(StudentsManage)
        /// </summary>
        /// <param name="context"></param>
        private void SetStudentsManageMeun(INavigationProviderContext context)
        {
            context.Manager.Menus.Add("StudentsManage", new MenuDefinition("StudentsManage", L("学生管理")));
            context.Manager.Menus["StudentsManage"].CustomData = new UserMenuExtendData { Icon = "icon-home" };
            context.Manager.Menus["StudentsManage"]
                .AddItem(new MenuItemDefinition(
                    "BusinessOne",
                    L("业务模块一"),
                    icon: "icon-home"
                    ).AddItem(new MenuItemDefinition(
                    "StudentRegister",
                    L("学生注册"),
                    url: "/StudentsManage/StudentRegister",
                    icon: "icon-users",
                    requiresAuthentication: true
                    )).AddItem(new MenuItemDefinition(
                        "ReplySetting",
                        L("学生选课"),
                        url: "/StudentsManage/ReplySetting",
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
        /// 设置教学管理导航栏(TeachingManage)
        /// </summary>
        /// <param name="context"></param>
        private void SetTeachingManageMeun(INavigationProviderContext context)
        {
            context.Manager.Menus.Add("TeachingManage", new MenuDefinition("TeachingManage", L("教学管理")));
            context.Manager.Menus["TeachingManage"].CustomData = new UserMenuExtendData { Icon = "icon-share" };
            context.Manager.Menus["TeachingManage"]
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
        /// 设置办公管理导航栏(WorkingManage)
        /// </summary>
        /// <param name="context"></param>
        private void SetWorkingManageMeun(INavigationProviderContext context)
        {
            context.Manager.Menus.Add("WorkingManage", new MenuDefinition("WorkingManage", L("办公管理")));
            context.Manager.Menus["WorkingManage"].CustomData = new UserMenuExtendData { Icon = "icon-users" };
            context.Manager.Menus["WorkingManage"]
                .AddItem(new MenuItemDefinition(
                    "BusinessOne",
                    L("系统设置一"),
                    icon: "icon-home"
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
            context.Manager.Menus["SysManage"].CustomData = new UserMenuExtendData { Icon = "icon-settings" };
            context.Manager.Menus["SysManage"]
                .AddItem(new MenuItemDefinition(
                    "BusinessOne",
                    L("系统管理一"),
                    icon: "fa fa-music"
                    ).AddItem(new MenuItemDefinition(
                    "Users",      //菜单功能名称与其controller保持一致,以判断当前被点击的菜单项
                    L("用户管理"),
                    url: "/SysManage/Users",
                    icon: "fa fa-music",
                    requiresAuthentication: true
                    )).AddItem(new MenuItemDefinition(
                        "Roles",
                        L("角色管理"),
                        url: "/SysManage/Roles",
                        icon: "fa fa-music",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "AuditLogs",
                        L("WebApi查询"),
                        url: "/swagger/ui/index",
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
                        "ThemeSetting",
                        L("主题设置"),
                        url: "/SysManage/ThemeSetting",
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