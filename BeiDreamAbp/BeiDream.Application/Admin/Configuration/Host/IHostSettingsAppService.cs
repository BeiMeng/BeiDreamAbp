using System.Threading.Tasks;
using Abp.Application.Services;
using BeiDream.Application.Admin.Configuration.Host.Dto;

namespace BeiDream.Application.Admin.Configuration.Host
{
    /// <summary>
    /// 全局的配置设置服务
    /// </summary>
    public interface IHostSettingsAppService : IApplicationService
    {
        /// <summary>
        /// 获取所有主题设置
        /// </summary>
        /// <returns></returns>
        Task<ThemeSettingEditDto> GetAllThemeSettings();
        /// <summary>
        /// 更新所有主题设置
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateAllThemeSettings(ThemeSettingEditDto input);
    }
}
