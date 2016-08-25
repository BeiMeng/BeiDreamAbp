using Abp.Runtime.Validation;

namespace BeiDream.Application.Admin.Configuration.Host.Dto
{
    /// <summary>
    /// 主题设置Dto
    /// </summary>
    public class ThemeSettingEditDto : IValidate
    {
        /// <summary>
        /// 默认主题颜色
        /// </summary>
        public  string ThemeColor { get; set; }
        /// <summary>
        /// 默认主题样式
        /// </summary>
        public  string ThemeStyle { get; set; }
        /// <summary>
        /// 默认布局
        /// </summary>
        public  string Layout  { get; set; }
        /// <summary>
        /// 头部位置
        /// </summary>
        public  string HeaderPosition { get; set; }
        /// <summary>
        /// 菜单栏模式
        /// </summary>
        public  string SidebarMode  { get; set; }
        /// <summary>
        /// 菜单栏样式
        /// </summary>
        public  string SidebarStyle  { get; set; }
        /// <summary>
        /// 子菜单栏风格
        /// </summary>
        public  string SidebarMenu  { get; set; }
        /// <summary>
        /// 菜单栏位置
        /// </summary>
        public  string SidebarPosition { get; set; }
        /// <summary>
        /// 页脚位置
        /// </summary>
        public  string FooterPosition  { get; set; }
        /// <summary>
        /// 头部下拉项的样式
        /// </summary>
        public string HeaderTopDropdownStyle { get; set; }
    }
}