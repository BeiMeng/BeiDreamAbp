using Abp.Application.Navigation;

namespace BeiDream.Mpa.Areas.Admin.Models.Layout
{
    public class SidebarViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; } 
    }
}