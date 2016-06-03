using Abp.Application.Navigation;

namespace BeiDream.PnSpa.Areas.Admin.Models.Layout
{
    public class SidebarViewModel
    {
        public UserMenu Menu { get; set; }

        public string ActivePageMenuName { get; set; }
    }
}