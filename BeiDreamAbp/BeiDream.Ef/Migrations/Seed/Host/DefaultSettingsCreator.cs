using System.Linq;
using Abp.Configuration;
using Abp.Localization;
using Abp.Net.Mail;
using BeiDream.Core.Admin.SysManage.ThemeSetting;
using BeiDream.Ef.EntityFramework;


namespace BeiDream.Ef.Migrations.Seed.Host
{
    public class DefaultSettingsCreator
    {
        private readonly BeiDreamAbpDbContext _context;

        public DefaultSettingsCreator(BeiDreamAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            //后台UI主题默认设置
            AddSettingIfNotExists(ThemeSettingOptionsNames.ThemeColor, "blue");
            AddSettingIfNotExists(ThemeSettingOptionsNames.ThemeStyle, "rounded");
            AddSettingIfNotExists(ThemeSettingOptionsNames.Layout, "fluid");
            AddSettingIfNotExists(ThemeSettingOptionsNames.SidebarMode, "fixed");
            AddSettingIfNotExists(ThemeSettingOptionsNames.SidebarPosition, "left");
            AddSettingIfNotExists(ThemeSettingOptionsNames.SidebarStyle, "compact");
            AddSettingIfNotExists(ThemeSettingOptionsNames.SidebarMenu, "accordion");
            AddSettingIfNotExists(ThemeSettingOptionsNames.HeaderPosition, "fixed");
            AddSettingIfNotExists(ThemeSettingOptionsNames.FooterPosition, "fixed");
            AddSettingIfNotExists(ThemeSettingOptionsNames.HeaderTopDropdownStyle, "light");
        }

        private void AddSettingIfNotExists(string name, string value, int? tenantId = null)
        {
            if (_context.Settings.Any(s => s.Name == name && s.TenantId == tenantId && s.UserId == null))
            {
                return;
            }

            _context.Settings.Add(new Setting(tenantId, null, name, value));
            _context.SaveChanges();
        }
    }
}