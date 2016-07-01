using Abp.Application.Navigation;

namespace BeiDream.MetronicMpa.Areas.Admin.Models.Layout
{
    public class SidebarViewModel
    {
        public UserMenu Menu { get; set; }

        public string ActivePageMenuName { get; set; }
        public string ActiveMenuName { get; set; } 
    }
}