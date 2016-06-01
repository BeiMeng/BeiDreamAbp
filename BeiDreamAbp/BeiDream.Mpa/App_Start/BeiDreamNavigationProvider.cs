using Abp.Application.Navigation;
using Abp.Localization;

namespace BeiDream.Mpa
{
    public class BeiDreamNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            SetBusinessMeun(context);
            SetSysManageMeun(context);
        }
        /// <summary>
        /// 设置业务菜单导航栏(Business)
        /// </summary>
        /// <param name="context"></param>
        private void SetBusinessMeun(INavigationProviderContext context)
        {
            context.Manager.Menus.Add("Business", new MenuDefinition("Business", L("业务管理")));
            context.Manager.Menus["Business"]
                .AddItem(new MenuItemDefinition(
                    "BusinessOne",
                    L("业务模块一"),
                    icon: "fa fa-music"
                    ).AddItem(new MenuItemDefinition(
                    "Users",
                    L("业务一"),
                    url: "/SystemManage/Users",
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
        /// 设置系统管理导航栏(SysManage)
        /// </summary>
        /// <param name="context"></param>
        private void SetSysManageMeun(INavigationProviderContext context)
        {
            context.Manager.Menus.Add("SysManage", new MenuDefinition("SysManage", L("系统管理")));
            context.Manager.Menus["SysManage"]
                .AddItem(new MenuItemDefinition(
                    "AAAAAAAAAA",
                    L("AAAAAAAAAAA"),
                    icon: "fa fa-music"
                    ).AddItem(new MenuItemDefinition(
                    "BBBBBBBBBBB",
                    L("BBBBBBBBBB"),
                    url: "/SystemManage/Users",
                    icon: "fa fa-music",
                    requiresAuthentication: true
                    )).AddItem(new MenuItemDefinition(
                        "CCCCCCCCCCCCC",
                        L("CCCCCCCCC"),
                        url: "/SystemManage/Roles",
                        icon: "fa fa-music",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "DDDDDDDDDDD",
                        L("DDDDDDDDDDDDD"),
                        url: "/SystemManage/AuditLogs",
                        icon: "fa fa-music",
                        requiresAuthentication: true
                    ))
                ).AddItem(
                    new MenuItemDefinition(
                        "EEEEEEEEEE",
                        L("EEEEEEEEEE"),
                        icon: "fa fa-info"
                        ).AddItem(new MenuItemDefinition(
                        "FFFFFFFFFFFFFF",
                        L("FFFFFFFFFFFFF"),
                        url: "/Business/InsuranceTypes",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "GGGGGGGGGG",
                        L("GGGGGGGGGGGGG"),
                        url: "/Business/CooperationCompanys",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                    .AddItem(new MenuItemDefinition(
                        "HHHHHHHHHHH",
                        L("HHHHHHHHHHHH"),
                        url: "/Business/VirtualCustomers",
                        icon: "fa fa-info",
                        requiresAuthentication: true
                    ))
                ).AddItem(
                    new MenuItemDefinition(
                        "YYYYYYYYYY",
                        L("YYYYYYYYYYYYYY"),
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