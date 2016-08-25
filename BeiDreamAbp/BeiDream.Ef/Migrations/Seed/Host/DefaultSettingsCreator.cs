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
            AddSettingIfNotExists(ThemeSettingOptionsName.ThemeColor, "blue");
            AddSettingIfNotExists(ThemeSettingOptionsName.ThemeStyle, "rounded");
            AddSettingIfNotExists(ThemeSettingOptionsName.Layout, "fluid");
            AddSettingIfNotExists(ThemeSettingOptionsName.SidebarMode, "fixed");
            AddSettingIfNotExists(ThemeSettingOptionsName.SidebarPosition, "left");
            AddSettingIfNotExists(ThemeSettingOptionsName.SidebarStyle, "compact");
            AddSettingIfNotExists(ThemeSettingOptionsName.SidebarMenu, "accordion");
            AddSettingIfNotExists(ThemeSettingOptionsName.HeaderPosition, "fixed");
            AddSettingIfNotExists(ThemeSettingOptionsName.FooterPosition, "fixed");
            AddSettingIfNotExists(ThemeSettingOptionsName.HeaderTopDropdownStyle, "light");
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