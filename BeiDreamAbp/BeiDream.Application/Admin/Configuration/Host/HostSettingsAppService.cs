using System;
using System.Threading.Tasks;
using Abp.Configuration;
using Abp.Net.Mail;
using BeiDream.Application.Admin.Configuration.Host.Dto;
using BeiDream.Core.Admin.SysManage.ThemeSetting;

namespace BeiDream.Application.Admin.Configuration.Host
{
    public class HostSettingsAppService : AppServiceBase, IHostSettingsAppService
    {
        public async Task<ThemeSettingEditDto> GetAllThemeSettings()
        {

            var themeSetting = new ThemeSettingEditDto
            {
                ThemeColor = await SettingManager.GetSettingValueAsync(ThemeSettingOptionsNames.ThemeColor),
                ThemeStyle =await SettingManager.GetSettingValueAsync(ThemeSettingOptionsNames.ThemeStyle),
                Layout = await SettingManager.GetSettingValueAsync(ThemeSettingOptionsNames.Layout),
                SidebarStyle = await SettingManager.GetSettingValueAsync(ThemeSettingOptionsNames.SidebarStyle),
                SidebarMode = await SettingManager.GetSettingValueAsync(ThemeSettingOptionsNames.SidebarMode),
                SidebarMenu = await SettingManager.GetSettingValueAsync(ThemeSettingOptionsNames.SidebarMenu),
                SidebarPosition = await SettingManager.GetSettingValueAsync(ThemeSettingOptionsNames.SidebarPosition),
                HeaderPosition = await SettingManager.GetSettingValueAsync(ThemeSettingOptionsNames.HeaderPosition),
                FooterPosition = await SettingManager.GetSettingValueAsync(ThemeSettingOptionsNames.FooterPosition),
                HeaderTopDropdownStyle = await SettingManager.GetSettingValueAsync(ThemeSettingOptionsNames.HeaderTopDropdownStyle)
            };


            return themeSetting;
        }

        public async Task UpdateAllThemeSettings(ThemeSettingEditDto input)
        {
            await SettingManager.ChangeSettingForApplicationAsync(ThemeSettingOptionsNames.ThemeColor, input.ThemeColor);
            await SettingManager.ChangeSettingForApplicationAsync(ThemeSettingOptionsNames.ThemeStyle, input.ThemeStyle);
            await SettingManager.ChangeSettingForApplicationAsync(ThemeSettingOptionsNames.Layout, input.Layout);
            await SettingManager.ChangeSettingForApplicationAsync(ThemeSettingOptionsNames.SidebarMode, input.SidebarMode);
            await SettingManager.ChangeSettingForApplicationAsync(ThemeSettingOptionsNames.SidebarStyle, input.SidebarStyle);
            await SettingManager.ChangeSettingForApplicationAsync(ThemeSettingOptionsNames.SidebarMenu, input.SidebarMenu);
            await SettingManager.ChangeSettingForApplicationAsync(ThemeSettingOptionsNames.SidebarPosition, input.SidebarPosition);
            await SettingManager.ChangeSettingForApplicationAsync(ThemeSettingOptionsNames.HeaderPosition, input.HeaderPosition);
            await SettingManager.ChangeSettingForApplicationAsync(ThemeSettingOptionsNames.HeaderTopDropdownStyle, input.HeaderTopDropdownStyle);
            await SettingManager.ChangeSettingForApplicationAsync(ThemeSettingOptionsNames.FooterPosition, input.FooterPosition);
        }
    }
}