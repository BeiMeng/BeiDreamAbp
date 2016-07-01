using System.Web.Mvc;

namespace BeiDream.MetronicMpa.Areas.TeachingManage
{
    public class TeachingManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TeachingManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TeachingManage_default",
                "TeachingManage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}