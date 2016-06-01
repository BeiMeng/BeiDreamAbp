using System.Web.Mvc;

namespace BeiDream.Mpa.Areas.MenuReply
{
    public class MenuReplyAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "MenuReply";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "MenuReply_default",
                "MenuReply/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}