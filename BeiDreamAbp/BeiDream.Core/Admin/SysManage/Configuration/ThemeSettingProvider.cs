using System.Collections.Generic;
using Abp.Configuration;
using Abp.Localization;
using BeiDream.Core.Admin.SysManage.ThemeSetting;

namespace BeiDream.Core.Admin.SysManage.Configuration
{
    /// <summary>
    /// 主题设置提供者
    /// </summary>
    public class ThemeSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
                   {
                       new SettingDefinition(ThemeSettingOptionsNames.ThemeColor, null, L("默认主题颜色"), scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                       new SettingDefinition(ThemeSettingOptionsNames.ThemeStyle, null, L("默认主题样式"), scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                       new SettingDefinition(ThemeSettingOptionsNames.Layout, null, L("默认布局"), scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                       new SettingDefinition(ThemeSettingOptionsNames.SidebarStyle, null, L("默认菜单样式"), scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                       new SettingDefinition(ThemeSettingOptionsNames.SidebarMode, null, L("默认布局"), scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                       new SettingDefinition(ThemeSettingOptionsNames.SidebarMenu, null, L("默认布局"), scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                       new SettingDefinition(ThemeSettingOptionsNames.SidebarPosition, null, L("默认布局"), scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                       new SettingDefinition(ThemeSettingOptionsNames.HeaderPosition, null, L("默认布局"), scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                       new SettingDefinition(ThemeSettingOptionsNames.FooterPosition, null, L("默认布局"), scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                       new SettingDefinition(ThemeSettingOptionsNames.HeaderTopDropdownStyle, null, L("默认布局"), scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                   };
        }
        private static ILocalizableString L(string name)
        {
            return new FixedLocalizableString(name);
        }
    }
}